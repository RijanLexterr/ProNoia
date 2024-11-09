<?php
// user_details.php - Create or Edit a user

include_once("../../connections/db.php");

// Define the salt to be used
define('SALT', 'SLIWM');

// Check if there is an ID in the query string (for editing an existing user)
if (isset($_GET['id'])) {
    // Fetch user details for editing
    $id = $_GET['id'];
    $sql = "SELECT * FROM user WHERE ID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $id);
    $stmt->execute();
    $result = $stmt->get_result();
    $user = $result->fetch_assoc();
    $isEditing = true;
} else {
    $isEditing = false;
    $user = ['ID' => '', 'Username' => '', 'Email' => '', 'IsActive' => 1, 'Password' => ''];
}

// Handle form submission (save or update)
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $username = $_POST['Username'];
    $email = $_POST['Email'];
    
    // Get the passwords
    $password = $_POST['Password'];
    $confirmPassword = $_POST['ConfirmPassword'];

    // Validate that passwords match
    if ($password !== $confirmPassword) {
        $error_message = "Passwords do not match!";
    } else {
        // Apply salt to the password
        $saltedPassword = SALT . $password;  // Concatenate the salt with the password
        $hashedPassword = password_hash($saltedPassword, PASSWORD_DEFAULT);  // Hash the salted password
        
        $isActive = isset($_POST['IsActive']) ? 1 : 0;

        if ($isEditing) {
            // Update the user
            $sql = "UPDATE user SET Username = ?, Email = ?, Password = ?, IsActive = ? WHERE ID = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("sssii", $username, $email, $hashedPassword, $isActive, $id);
        } else {
            // Insert new user
            $sql = "INSERT INTO user (Username, Email, Password, IsActive) VALUES (?, ?, ?, ?)";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("sssi", $username, $email, $hashedPassword, $isActive);
        }

        if ($stmt->execute()) {
            // Redirect to the user list page after successful save
            header('Location: user_list.php');
            exit();
        } else {
            echo "Error: " . $conn->error;
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User Details</title>

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
                <h1 class="text-center mb-4"><?= $isEditing ? 'Edit User' : 'Create User' ?></h1>

                <!-- Error Message (if passwords do not match) -->
                <?php if (isset($error_message)): ?>
                    <div class="alert alert-danger"><?= $error_message ?></div>
                <?php endif; ?>

                <!-- User Form -->
                <form method="post">
                    <!-- Username -->
                    <div class="form-group">
                        <label for="Username">Username</label>
                        <input type="text" class="form-control" id="Username" name="Username" value="<?= $user['Username'] ?>" required>
                    </div>

                    <!-- Email -->
                    <div class="form-group">
                        <label for="Email">Email</label>
                        <input type="email" class="form-control" id="Email" name="Email" value="<?= $user['Email'] ?>" required>
                    </div>

                    <!-- Password -->
                    <div class="form-group">
                        <label for="Password">Password</label>
                        <input type="password" class="form-control" id="Password" name="Password" <?= !$isEditing ? 'required' : '' ?>>
                    </div>

                    <!-- Confirm Password -->
                    <div class="form-group">
                        <label for="ConfirmPassword">Confirm Password</label>
                        <input type="password" class="form-control" id="ConfirmPassword" name="ConfirmPassword" <?= !$isEditing ? 'required' : '' ?>>
                    </div>

                    <!-- Is Active -->
                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="IsActive" name="IsActive" <?= $user['IsActive'] ? 'checked' : '' ?>>
                        <label class="form-check-label" for="IsActive">Is Active</label>
                    </div>

                    <!-- Button Group -->
                    <div class="d-flex justify-content-between mt-3">
                        <!-- Submit Button -->
                        <button type="submit" class="btn btn-primary btn-sm"><?= $isEditing ? 'Update User' : 'Create User' ?></button>

                        <!-- Back Button -->
                        <a href="user_list.php" class="btn btn-secondary btn-sm">Back to User List</a>
                    </div>
                </form>

            </div>
        </div>
    </div>

</body>
</html>
