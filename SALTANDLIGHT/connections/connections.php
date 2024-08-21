<?php  

function connection(){

   
$servername = "localhost";
$username = "root";
$password = "";
$database = "sli";

// Create connection
$conn = new mysqli($servername, $username, $password, $database);
// Check connection
if ($conn->connect_error) {
  echo $conn->connect_error;
 } else{

    return $conn;

 }

}