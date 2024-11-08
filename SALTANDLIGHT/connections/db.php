<?php
// db.php - Database connection script
$host = 'localhost';    // Your MySQL host (usually localhost)
$username = 'root';     // Your MySQL username
$password = '';         // Your MySQL password
$dbname = 'sli';        // Database name

// Create connection
$conn = new mysqli($host, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>
