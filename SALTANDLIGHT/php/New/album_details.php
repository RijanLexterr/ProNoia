<?php
// Include the database connection
include_once("../../connections/db.php");

// Initialize variables
$id = $label = $isActive = '';
$isEditing = false;
$album = ['ID' => '', 'Label' => '', 'IsActive' => 1, 'CreatedDate' => '', 'UpdatedDate' => '', 'CreatedBy' => '', 'UpdatedBy' => ''];  // Ensure IsActive is always present

// Check if we're editing an album
if (isset($_GET['id'])) {
    $id = $_GET['id'];
    $sql = "SELECT * FROM album WHERE ID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $id);
    $stmt->execute();
    $result = $stmt->get_result();
    $album = $result->fetch_assoc();
    $isEditing = true;
}

// Handle form submission for album save or update
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Handle file deletion
    if (isset($_POST['delete']) && isset($_POST['selectedFiles'])) {
        $selectedFiles = $_POST['selectedFiles'];

        foreach ($selectedFiles as $fileID) {
            // Fetch file from database to get the file path
            $sqlDelete = "SELECT * FROM files WHERE ID = ?";
            $stmtDelete = $conn->prepare($sqlDelete);
            $stmtDelete->bind_param("i", $fileID);
            $stmtDelete->execute();
            $resultDelete = $stmtDelete->get_result();
            $fileToDelete = $resultDelete->fetch_assoc();
            $filePathToDelete = $fileToDelete['Path'];

            // Delete file from server
            if (file_exists($filePathToDelete)) {
                unlink($filePathToDelete);
            }

            // Delete file from the database
            $sqlDeleteFile = "DELETE FROM files WHERE ID = ?";
            $stmtDeleteFile = $conn->prepare($sqlDeleteFile);
            $stmtDeleteFile->bind_param("i", $fileID);
            $stmtDeleteFile->execute();
        }
    }

    // Handle Moving Files to Another Album
    if (isset($_POST['moveFiles']) && isset($_POST['selectedFiles']) && isset($_POST['albumID'])) {
        $selectedFiles = $_POST['selectedFiles'];
        $newAlbumID = $_POST['albumID'];

        foreach ($selectedFiles as $fileID) {
            // Update the album ID for the selected files
            $sqlMove = "UPDATE files SET AlbumID = ? WHERE ID = ?";
            $stmtMove = $conn->prepare($sqlMove);
            $stmtMove->bind_param("ii", $newAlbumID, $fileID);
            $stmtMove->execute();
        }

        // Redirect after moving files
        header('Location: album_details.php?id=' . $album['ID']);
        exit();
    }
}


// Fetch all albums for the "Move to Album" dropdown
$albumsQuery = "SELECT ID, Label FROM album";
$albumsResult = $conn->query($albumsQuery);

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Album Details</title>

    <!-- Bootstrap CSS -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">

    <!-- Link to Sidebar CSS -->
    <link href="../../css/sidebar.css" rel="stylesheet">

    <!-- Link to Custom CSS -->
    <link href="../../css/custom.css" rel="stylesheet">
</head>

<body>
    <!-- Side Navbar -->
    <div class="sidebar">
        <h3 class="text-center text-white mb-4">Menu</h3>
        <a href="dashboard.php">Dashboard</a> <!-- Dashboard is now the first menu item -->
        <a href="user_list.php">Users</a>
        <a href="role_list.php">Roles</a>
        <a href="position_list.php">Positions</a>
        <a href="album_list.php">Albums</a>
        <a href="file_list.php">Files</a>
        <a href="user_details.php">User Details</a>
    </div>

    <div class="container-fluid">
        <div class="row justify-content-center">
            <!-- Album Details Card -->
            <div class="col-12 col-md-8 col-lg-10">
                <div class="card">
                    <div class="card-body">
                        <h1 class="text-center"><?= $isEditing ? 'Edit Album' : 'Create Album' ?></h1>

                        <form method="post" class="mt-4">
                            <!-- Album Label -->
                            <div class="form-group">
                                <label for="Label">Album Name</label>
                                <input type="text" class="form-control" id="Label" name="Label"
                                    value="<?= $album['Label'] ?>" required>
                            </div>

                            <!-- Is Active Checkbox -->
                            <div class="form-check">
                                <input type="checkbox" class="form-check-input" id="IsActive" name="IsActive"
                                    <?= isset($album['IsActive']) && $album['IsActive'] ? 'checked' : '' ?>>
                                <label class="form-check-label" for="IsActive">Is Active</label>
                            </div>

                            <!-- Submit Button -->
                            <button type="submit" name="saveAlbum"
                                class="btn btn-primary btn-sm mt-3"><?= $isEditing ? 'Update Album' : 'Create Album' ?></button>
                        </form>
                    </div>
                </div>
            </div>

            <!-- File Upload Form -->
            <div class="col-12 col-md-8 col-lg-10 mt-4">
                <div class="card">
                    <div class="card-body">
                        <h4>Upload Files</h4>
                        <form method="post" enctype="multipart/form-data">
                            <div class="form-group">
                                <label for="files">Select Files</label>
                                <input type="file" class="form-control-file" name="files[]" multiple required>
                                <input type="hidden" name="albumID" value="<?= $album['ID'] ?>">
                            </div>
                            <button type="submit" name="saveFiles" class="btn btn-primary btn-sm">Upload Files</button>
                        </form>
                    </div>
                </div>
            </div>

            <!-- File Gallery -->
            <div class="col-12 col-md-8 col-lg-10 mt-4">
                <div class="card">
                    <div class="card-body">
                        <h4>Uploaded Files</h4>

                        <!-- Move to Album and Delete Buttons -->


                        <form method="POST" class="mt-3">
                            <!-- Move to Album Modal -->
                            <div class="modal fade" id="moveModal" tabindex="-1" role="dialog"
                                aria-labelledby="moveModalLabel" aria-hidden="true">
                                <div class="modal-dialog" role="document">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h5 class="modal-title" id="moveModalLabel">Move Files to Another Album</h5>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"
                                                onclick="removeRequired()">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body">
                                            <div class="form-group">
                                                <label for="albumID">Select Album</label>
                                                <select class="form-control" name="albumID" id="albumID">
                                                    <option value="">Select an Album</option>
                                                    <?php
                                                    while ($albumOption = $albumsResult->fetch_assoc()) {
                                                        echo '<option value="' . $albumOption['ID'] . '">' . $albumOption['Label'] . '</option>';
                                                    }
                                                    ?>
                                                </select>
                                            </div>
                                            <button type="submit" name="moveFiles" class="btn btn-primary btn-sm">Move
                                                Files</button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <!-- JavaScript to Add/Remove Required Attribute -->
                            <script>
                                // Add the 'required' attribute when the Move button is clicked
                                document.getElementById('moveButton').addEventListener('click', function () {
                                    const albumSelect = document.getElementById('albumID');
                                    albumSelect.setAttribute('required', 'true'); // Add the required attribute
                                });

                                // Remove the 'required' attribute when the modal is closed
                                function removeRequired() {
                                    const albumSelect = document.getElementById('albumID');
                                    albumSelect.removeAttribute('required'); // Remove the required attribute
                                }
                            </script>

                            <!-- Move to Album and Delete Buttons -->
                            <div class="d-flex mb-3">
                                <!-- Move Button (visible when files are selected) -->
                                <button type="button" class="btn btn-warning btn-sm mr-2" id="moveButton"
                                    name="moveFiles" data-toggle="modal" data-target="#moveModal"
                                    style="display: none;">Move to Album</button>

                                <!-- Delete Button (visible when files are selected) -->
                                <button type="submit" id="deleteSelectedFiles" class="btn btn-danger btn-sm"
                                    name="delete" style="display: none;">Delete Selected Files</button>
                            </div>

                            <!-- File Gallery -->
                            <div class="row mt-3">
                                <?php
                                // Fetch files for this album
                                $sqlFiles = "SELECT * FROM files WHERE AlbumID = ?";
                                $stmtFiles = $conn->prepare($sqlFiles);
                                $stmtFiles->bind_param("i", $album['ID']);
                                $stmtFiles->execute();
                                $resultFiles = $stmtFiles->get_result();

                                while ($file = $resultFiles->fetch_assoc()) {
                                    echo '<div class="col-md-3 mb-3">';
                                    echo '<div class="card position-relative">';
                                    echo '<img src="' . $file['Path'] . '" class="card-img-top" alt="File Thumbnail">';
                                    echo '<input type="checkbox" name="selectedFiles[]" value="' . $file['ID'] . '" class="position-absolute top-0 right-0 m-2" onchange="toggleButtons()">';
                                    echo '</div>';
                                    echo '</div>';
                                }
                                ?>
                            </div>


                        </form>
                    </div>
                </div>
            </div>



        </div>
    </div>

    <!-- Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <script>
        // Toggle "Move to Album" and "Delete" button visibility
        function toggleButtons() {
            const checkboxes = document.querySelectorAll('input[name="selectedFiles[]"]');
            const moveButton = document.getElementById('moveButton');
            const deleteButton = document.getElementById('deleteSelectedFiles');
            let isSelected = false;

            checkboxes.forEach(function (checkbox) {
                if (checkbox.checked) {
                    isSelected = true;
                }
            });

            moveButton.style.display = isSelected ? 'inline-block' : 'none';
            deleteButton.style.display = isSelected ? 'inline-block' : 'none';
        }
    </script>
</body>

</html>