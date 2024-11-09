<?php
// role_details.php - Create or Edit Role

include_once("../../connections/db.php");

// Check if we are editing an existing role or creating a new one
$roleID = isset($_GET['id']) ? $_GET['id'] : null;
$role = null;

if ($roleID) {
    // Fetch role data for editing
    $sql = "SELECT * FROM Role WHERE ID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $roleID);
    $stmt->execute();
    $result = $stmt->get_result();
    if ($result->num_rows > 0) {
        $role = $result->fetch_assoc();
    } else {
        die("Role not found.");
    }
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $label = $_POST['label'];
    $description = $_POST['description'];

    if ($roleID) {
        // Update role
        $sql = "UPDATE Role SET Label = ?, Description = ? WHERE ID = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ssi", $label, $description, $roleID);
        $stmt->execute();
        header("Location: role_list.php"); // Redirect to role list page after updating
    } else {
        // Create new role
        $sql = "INSERT INTO Role (Label, Description) VALUES (?, ?)";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ss", $label, $description);
        $stmt->execute();
        header("Location: role_list.php"); // Redirect to role list page after inserting
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php echo $roleID ? 'Edit' : 'Create'; ?> Role</title>

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

    <div class="container" style="margin-left: 250px; padding-top: 20px;">
        <h1 class="text-center mb-4"><?php echo $roleID ? 'Edit' : 'Create'; ?> Role</h1>

        <!-- Role Form -->
        <div class="card">
            <div class="card-body">
                <form method="POST">
                    <div class="form-group">
                        <label for="label">Role Name</label>
                        <input type="text" class="form-control" id="label" name="label" value="<?php echo $role ? $role['Label'] : ''; ?>" required>
                    </div>
                    <div class="form-group">
                        <label for="description">Description</label>
                        <textarea class="form-control" id="description" name="description" rows="4" required><?php echo $role ? $role['Description'] : ''; ?></textarea>
                    </div>
                    <button type="submit" class="btn btn-primary"><?php echo $roleID ? 'Update' : 'Create'; ?> Role</button>
                </form>
            </div>
        </div>
    </div>

</body>
</html>
