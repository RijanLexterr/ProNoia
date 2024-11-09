<?php
// check_session.php - Check if the user is logged in

// Start the session if it's not already started
if (session_status() == PHP_SESSION_NONE) {
    session_start();
}

// Check if the user is logged in by verifying session variables
if (!isset($_SESSION['user_id']) || !isset($_SESSION['username'])) {
    // Redirect to login page if not logged in
    header('Location: login.php');
    exit(); // Stop further script execution
}
?>
