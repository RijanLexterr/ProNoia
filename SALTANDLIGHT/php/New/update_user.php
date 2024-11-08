<?php
// update_user.php - Insert or update user details
include_once("../../connections/db.php");

// Check if form is submitted
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Get the submitted values
    $id = $_POST['id'];
    $username = $_POST['Username'];
    $email = $_POST['Email'];
    $isActive = isset($_POST['IsActive']) ? 1 : 0; // Convert checkbox to 1 or 0
    $password = $_POST['Password'];
    $confirmPassword = $_POST['ConfirmPassword'];

    // Basic server-side validation
    if ($password !== $confirmPassword) {
        echo "Passwords do not match!";
        exit;
    }

    // Check if password is at least 8 characters
    if (strlen($password) < 8) {
        echo "Password must be at least 8 characters long.";
        exit;
    }

    // Check if the email is already in use (for new users or updates)
    $emailCheckSql = "SELECT * FROM user WHERE Email = ? AND ID != ?";
    $stmt = $conn->prepare($emailCheckSql);
    $stmt->bind_param("si", $email, $id);
    $stmt->execute();
    $emailResult = $stmt->get_result();

    if ($emailResult->num_rows > 0) {
        echo "Email is already in use.";
        exit;
    }

    // If the password field is not empty, hash the new password
    $passwordHash = password_hash($password, PASSWORD_BCRYPT);

    if (empty($id)) {
        // Insert a new user if ID is empty (new record)
        $sql = "INSERT INTO user (Username, Email, IsActive, Password) VALUES (?, ?, ?, ?)";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ssis", $username, $email, $isActive, $passwordHash);
    } else {
        // Update existing user
        $sql = "UPDATE user SET Username = ?, Email = ?, IsActive = ?, Password = ? WHERE ID = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ssisi", $username, $email, $isActive, $passwordHash, $id);
    }

    // Execute the query and check for success
    if ($stmt->execute()) {
        if (empty($id)) {
            echo "New user created successfully!";
        } else {
            echo "User details updated successfully!";
        }
    } else {
        echo "Error: " . $conn->error;
    }

    $stmt->close();
    $conn->close();
} else {
    echo "Invalid request!";
}
?>
