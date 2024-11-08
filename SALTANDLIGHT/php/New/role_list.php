<?php
// role_list.php - Display a list of all roles

include_once("../../connections/db.php");

// Fetch all roles from the database
$sql = "SELECT * FROM Role";
$result = $conn->query($sql);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Role List</title>

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
        <a href="user_list.php">Users</a>
        <a href="role_list.php">Roles</a>
        <a href="position_list.php">Positions</a>
        <a href="album_list.php">Albums</a>
        <a href="file_list.php">Files</a>
        <a href="user_details.php">User Details</a>
    </div>

    <div class="container" style="margin-left: 250px; padding-top: 20px;">
        <h1 class="text-center mb-4">Role List</h1>

        <!-- Display success message if applicable -->
        <?php
        if (isset($_GET['message'])) {
            echo '<div class="alert alert-success" role="alert">' . htmlspecialchars($_GET['message']) . '</div>';
        }
        ?>

        <!-- Table displaying all roles -->
        <div class="card">
            <div class="card-body">
                <!-- Create New Role Button (Aligned to the right) -->
                <div class="d-flex justify-content-end mb-3">
                    <a href="role_details.php" class="btn btn-primary btn-sm">Create New Role</a>
                </div>

                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Role Name</th>
                            <th>Description</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php
                        if ($result->num_rows > 0) {
                            while($row = $result->fetch_assoc()) {
                                echo "<tr>";
                                echo "<td>" . $row['ID'] . "</td>";
                                echo "<td>" . $row['Label'] . "</td>";
                                echo "<td>" . $row['Description'] . "</td>";
                                echo "<td>
                                        <a href='role_details.php?id=" . $row['ID'] . "' class='btn btn-info btn-sm'>Edit</a>
                                        <a href='Role/delete_role.php?id=" . $row['ID'] . "' class='btn btn-danger btn-sm' onclick='return confirm(\"Are you sure you want to delete?\")'>Delete</a>
                                      </td>";
                                echo "</tr>";
                            }
                        } else {
                            echo "<tr><td colspan='4' class='text-center'>No roles found</td></tr>";
                        }
                        ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</body>
</html>
