<?php
// user_role_details.php - Create or Edit a user-role association

include_once("../../connections/db.php");

// Initialize variables
$isEditing = false;
$user_role = ['ID' => '', 'UserID' => '', 'RoleID' => ''];  // Default empty values

// Check if we are editing an existing user-role association
if (isset($_GET['id'])) {
    $id = $_GET['id'];
    $sql = "SELECT ur.ID, ur.UserID, ur.RoleID, u.Username, r.Label AS Role
            FROM UserRole ur
            JOIN user u ON ur.UserID = u.ID
            JOIN Role r ON ur.RoleID = r.ID
            WHERE ur.ID = ?";

    if ($stmt = $conn->prepare($sql)) {
        $stmt->bind_param("i", $id);
        $stmt->execute();
        $result = $stmt->get_result();
        $user_role = $result->fetch_assoc();
        $isEditing = true;
        $stmt->close();
    }
}

// Handle form submission (save or update user-role association)
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $user_id = $_POST['user_id'];
    $role_id = $_POST['role_id'];

    if ($isEditing) {
        // Update existing user-role association
        $sql = "UPDATE UserRole SET UserID = ?, RoleID = ? WHERE ID = ?";
        if ($stmt = $conn->prepare($sql)) {
            $stmt->bind_param("iii", $user_id, $role_id, $id);
            $stmt->execute();
            $stmt->close();
            header("Location: user_role_list.php");  // Redirect after save
            exit();
        }
    } else {
        // Insert new user-role association
        $sql = "INSERT INTO UserRole (UserID, RoleID) VALUES (?, ?)";
        if ($stmt = $conn->prepare($sql)) {
            $stmt->bind_param("ii", $user_id, $role_id);
            $stmt->execute();
            $stmt->close();
            header("Location: user_role_list.php");  // Redirect after save
            exit();
        }
    }
}

// Fetch users for the dropdown
$sql_users = "SELECT ID, Username FROM user";
$result_users = $conn->query($sql_users);

// Fetch roles for the dropdown
$sql_roles = "SELECT ID, Label FROM Role";
$result_roles = $conn->query($sql_roles);
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php echo $isEditing ? 'Edit User Role' : 'Create User Role'; ?></title>

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
                <h1 class="text-center mb-4"><?= $isEditing ? 'Edit User Role' : 'Create User Role' ?></h1>

                <!-- User Role Form -->
                <form method="post">
                    <!-- User Dropdown -->
                    <div class="form-group">
                        <label for="user_id">User</label>
                        <select class="form-control" id="user_id" name="user_id" required>
                            <option value="">Select User</option>
                            <?php while ($user = $result_users->fetch_assoc()): ?>
                                <option value="<?php echo $user['ID']; ?>" <?php echo $user_role['UserID'] == $user['ID'] ? 'selected' : ''; ?>>
                                    <?php echo $user['Username']; ?>
                                </option>
                            <?php endwhile; ?>
                        </select>
                    </div>

                    <!-- Role Dropdown -->
                    <div class="form-group">
                        <label for="role_id">Role</label>
                        <select class="form-control" id="role_id" name="role_id" required>
                            <option value="">Select Role</option>
                            <?php while ($role = $result_roles->fetch_assoc()): ?>
                                <option value="<?php echo $role['ID']; ?>" <?php echo $user_role['RoleID'] == $role['ID'] ? 'selected' : ''; ?>>
                                    <?php echo $role['Label']; ?>
                                </option>
                            <?php endwhile; ?>
                        </select>
                    </div>

                    <!-- Button Group -->
                    <div class="d-flex justify-content-between mt-3">
                        <!-- Submit Button -->
                        <button type="submit"
                            class="btn btn-primary btn-sm"><?= $isEditing ? 'Update User Role' : 'Create User Role' ?></button>

                        <!-- Back Button -->
                        <a href="user_role_list.php" class="btn btn-secondary btn-sm">Back to User Role List</a>
                    </div>
                </form>

            </div>
        </div>
    </div>

</body>

</html>