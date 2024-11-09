<?php
// file_list.php - List all files

include_once("../../connections/db.php");

// Fetch all files from the database
$sql = "SELECT f.ID, f.Label, f.FileName, f.UploadedDate, u.Username AS UploadedBy, f.IsActive FROM files f JOIN user u ON f.UploadedBy = u.ID";
$result = $conn->query($sql);

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>File List</title>

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

    <div class="container mt-5">
        <h2>File List</h2>

        <a href="file_details.php" class="btn btn-primary btn-sm mb-3">Add New File</a>

        <!-- Table for files -->
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Label</th>
                    <th>File Name</th>
                    <th>Uploaded By</th>
                    <th>Uploaded Date</th>
                    <th>Status</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php while ($row = $result->fetch_assoc()) { ?>
                    <tr>
                        <td><?= $row['ID'] ?></td>
                        <td><?= $row['Label'] ?></td>
                        <td><?= $row['FileName'] ?></td>
                        <td><?= $row['UploadedBy'] ?></td>
                        <td><?= $row['UploadedDate'] ?></td>
                        <td><?= $row['IsActive'] ? 'Active' : 'Inactive' ?></td>
                        <td>
                            <a href="file_details.php?id=<?= $row['ID'] ?>" class="btn btn-warning btn-sm">Edit</a>
                            <!-- Add delete functionality if needed -->
                        </td>
                    </tr>
                <?php } ?>
            </tbody>
        </table>
    </div>

</body>
</html>
