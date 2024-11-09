<?php
// logout.php - Handles user logout

session_start();

// Destroy the session to log out the user
session_destroy();

// Redirect to login page
header('Location: login.php');
exit();
?>
