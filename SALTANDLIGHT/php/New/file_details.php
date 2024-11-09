<?php
// file_details.php - Create or Edit a file

include_once("../../connections/db.php");

// Check if there is an ID in the query string (for editing an existing file)
if (isset($_GET['id'])) {
    // Fetch file details for editing
    $id = $_GET['id'];
    $sql = "SELECT * FROM files WHERE ID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $id);
    $stmt->execute();
    $result = $stmt->get_result();
    $file = $result->fetch_assoc();
    $isEditing = true;
} else {
    $isEditing = false;
    $file = ['ID' => '', 'Label' => '', 'FileName' => '', 'IsActive' => 1, 'UploadedBy' => '', 'UploadedDate' => '', 'Path' => '', 'Link' => '', 'isIntegrated' => 0, 'AlbumID' => ''];
}

// Fetch all albums for the dropdown
$albumQuery = "SELECT ID, Label FROM album WHERE IsActive = 1"; // Only fetch active albums
$albumResult = $conn->query($albumQuery);

// Handle form submission (save or update)
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $label = $_POST['Label'];
    $fileName = $_POST['FileName'];
    $uploadedBy = $_POST['UploadedBy']; // Assume this is the current user ID
    $isActive = isset($_POST['IsActive']) ? 1 : 0;
    $link = $_POST['Link'];
    $isIntegrated = isset($_POST['isIntegrated']) ? 1 : 0;
    $albumID = $_POST['AlbumID']; // The selected album ID

    // Get the current date for the UploadedDate
    $uploadedDate = date('Y-m-d'); // Current date in 'YYYY-MM-DD' format

    // Handle file upload
    $path = ''; // Default value for path
    if (isset($_FILES['FileUpload']) && $_FILES['FileUpload']['error'] == 0) {
        $fileTmpPath = $_FILES['FileUpload']['tmp_name'];
        $fileName = $_FILES['FileUpload']['name'];
        
        // Define upload folder and ensure it exists
        $uploadFolder = 'files/';
        if (!is_dir($uploadFolder)) {
            mkdir($uploadFolder, 0777, true);
        }
        
        // Generate a unique filename to avoid overwriting
        $uniqueFileName = time() . '_' . basename($fileName);
        $filePath = $uploadFolder . $uniqueFileName;
        
        // Move the uploaded file to the server
        if (move_uploaded_file($fileTmpPath, $filePath)) {
            // Successfully uploaded
            $path = $filePath;  // Store the file path
        } else {
            echo "Error uploading the file.";
        }
    }

    // Set the path to be stored in the database (relative to the server)
    $filePath = 'file/' . basename($filePath);

    // If editing, update the file details
    if ($isEditing) {
        $sql = "UPDATE files SET Label = ?, FileName = ?, UploadedBy = ?, IsActive = ?, Path = ?, Link = ?, isIntegrated = ?, AlbumID = ?, UploadedDate = ? WHERE ID = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ssiiisssii", $label, $fileName, $uploadedBy, $isActive, $path, $link, $isIntegrated, $albumID, $uploadedDate, $id);
    } else {
        // Insert a new file
        $sql = "INSERT INTO files (Label, FileName, UploadedBy, IsActive, Path, Link, isIntegrated, AlbumID, UploadedDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ssiiisssi", $label, $fileName, $uploadedBy, $isActive, $path, $link, $isIntegrated, $albumID, $uploadedDate);
    }

    if ($stmt->execute()) {
        // Redirect to the file list page after successful save
        header('Location: file_list.php');
        exit();
    } else {
        echo "Error: " . $conn->error;
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>File Details</title>

    <!-- Bootstrap 4 CSS -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">

 <!-- Link to sidebar.css -->
 <link href="../../css/sidebar.css" rel="stylesheet">

<!-- Link to custom.css -->
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

    <div class="container-fluid d-flex justify-content-center align-items-center min-vh-100">
        <div class="card" style="width: 40%; max-width: 500px;">
            <div class="card-body">
                <h1 class="text-center mb-4"><?= $isEditing ? 'Edit File' : 'Create File' ?></h1>

                <!-- File Form -->
                <form method="post" enctype="multipart/form-data">
                    <!-- Label -->
                    <div class="form-group">
                        <label for="Label">Label</label>
                        <input type="text" class="form-control" id="Label" name="Label" value="<?= $file['Label'] ?>" required>
                    </div>

                    <!-- File Name -->
                    <div class="form-group">
                        <label for="FileName">File Name</label>
                        <input type="text" class="form-control" id="FileName" name="FileName" value="<?= $file['FileName'] ?>" required>
                    </div>

                    <!-- Uploaded By -->
                    <div class="form-group">
                        <label for="UploadedBy">Uploaded By (User ID)</label>
                        <input type="number" class="form-control" id="UploadedBy" name="UploadedBy" value="<?= $file['UploadedBy'] ?>" required>
                    </div>

                    <!-- Path -->
                    <div class="form-group">
                        <label for="Path">Path</label>
                        <input type="text" class="form-control" id="Path" name="Path" value="<?= $file['Path'] ?>" readonly>
                    </div>

                    <!-- File Upload -->
                    <div class="form-group">
                        <label for="FileUpload">Upload File</label>
                        <input type="file" class="form-control" id="FileUpload" name="FileUpload" <?= !$isEditing ? 'required' : '' ?>>
                    </div>

                    <!-- Link -->
                    <div class="form-group">
                        <label for="Link">Link</label>
                        <input type="text" class="form-control" id="Link" name="Link" value="<?= $file['Link'] ?>" required>
                    </div>

                    <!-- Album Selection -->
                    <div class="form-group">
                        <label for="AlbumID">Select Album</label>
                        <select class="form-control" id="AlbumID" name="AlbumID" required>
                            <option value="">Select an Album</option>
                            <?php while ($album = $albumResult->fetch_assoc()) { ?>
                                <option value="<?= $album['ID'] ?>" <?= $file['AlbumID'] == $album['ID'] ? 'selected' : '' ?>>
                                    <?= $album['Label'] ?>
                                </option>
                            <?php } ?>
                        </select>
                    </div>

                    <!-- Is Active -->
                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="IsActive" name="IsActive" <?= $file['IsActive'] ? 'checked' : '' ?>>
                        <label class="form-check-label" for="IsActive">Is Active</label>
                    </div>

                    <!-- is Integrated -->
                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="isIntegrated" name="isIntegrated" <?= $file['isIntegrated'] ? 'checked' : '' ?>>
                        <label class="form-check-label" for="isIntegrated">is Integrated</label>
                    </div>

                    <!-- Button Group -->
                    <div class="d-flex justify-content-between mt-3">
                        <!-- Submit Button -->
                        <button type="submit" class="btn btn-primary btn-sm"><?= $isEditing ? 'Update File' : 'Create File' ?></button>

                        <!-- Back Button -->
                        <a href="file_list.php" class="btn btn-secondary btn-sm">Back to File List</a>
                    </div>
                </form>

            </div>
        </div>
    </div>

</body>
</html>
