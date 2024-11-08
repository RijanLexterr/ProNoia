<?php
// delete_role.php - Delete a role

include_once("../../../connections/db.php");

if (isset($_GET['id'])) {
    // Get the role ID from the URL
    $roleID = $_GET['id'];

    // Prepare SQL statement to delete the role
    $sql = "DELETE FROM Role WHERE ID = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $roleID);

    // Execute the deletion query
    if ($stmt->execute()) {
        // Redirect to the role list page after deletion
        header("Location: ../role_list.php?message=Role+deleted+successfully");
    } else {
        // Handle any errors during the deletion
        echo "Error deleting role: " . $stmt->error;
    }
} else {
    // If no ID is provided in the URL, show an error
    echo "Role ID not provided.";
}

?>
