<?php
// login.php - User Login

include_once("../../connections/db.php");

// Define the salt to be used (same as in user_details.php)
define('SALT', 'SLIWM');

// Start the session
session_start();

// Check if the user is already logged in, if yes, redirect to user list page
if (isset($_SESSION['user_id'])) {
    header('Location: user_list.php');
    exit();
}

// Handle form submission
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $username = $_POST['Username'];
    $password = $_POST['Password'];

    // Prepare SQL query to get the user data based on the username
    $sql = "SELECT * FROM user WHERE Username = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("s", $username);
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows > 0) {
        // User exists, fetch the user data
        $user = $result->fetch_assoc();

        // Salt and hash the entered password and compare it with the stored hash
        $saltedPassword = SALT . $password;  // Concatenate the salt with the entered password

        if (password_verify($saltedPassword, $user['Password'])) {
            // Password is correct, start a session and redirect to user list
            $_SESSION['user_id'] = $user['ID'];  // Store the user ID in session
            $_SESSION['username'] = $user['Username'];
            header('Location: dashboard.php');
            exit();
        } else {
            // Password is incorrect
            $error_message = "Invalid username or password!";
        }
    } else {
        // Username not found
        $error_message = "Invalid username or password!";
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>

    <!-- Bootstrap 4 CSS -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">

    <!-- Link to custom CSS -->
    <link href="../../css/custom.css" rel="stylesheet">

</head>
<body class="d-flex justify-content-center align-items-center min-vh-100 bg-light">

    <div class="card" style="width: 30%; max-width: 400px;">
        <div class="card-body">
            <h3 class="text-center mb-4">Login</h3>

            <!-- Error Message (if credentials are incorrect) -->
            <?php if (isset($error_message)): ?>
                <div class="alert alert-danger"><?= $error_message ?></div>
            <?php endif; ?>

            <!-- Login Form -->
            <form method="post">
                <!-- Username -->
                <div class="form-group">
                    <label for="Username">Username</label>
                    <input type="text" class="form-control" id="Username" name="Username" required>
                </div>

                <!-- Password -->
                <div class="form-group">
                    <label for="Password">Password</label>
                    <input type="password" class="form-control" id="Password" name="Password" required>
                </div>

                <!-- Login Button -->
                <button type="submit" class="btn btn-primary btn-block">Login</button>

            </form>

            <hr>

            <!-- Link to register if the user doesn't have an account -->
            <p class="text-center">
                Don't have an account? <a href="user_details.php">Create one here</a>
            </p>
        </div>
    </div>

</body>
</html>
