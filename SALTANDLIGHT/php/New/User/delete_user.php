<?php
// delete_user.php - Delete user from the database

include('db.php');

// Check if an ID is passed to the URL
if (isset($_GET['id'])) {
    $id = $_GET['id'];

    // Delete the user from the database
    $sql = "DELETE FROM user WHERE ID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $id);

    if ($stmt->execute()) {
        // Redirect back to the user list page after successful deletion
        header("Location: user_list.php");
    } else {
        echo "Error: " . $conn->error;
    }
}
?>
