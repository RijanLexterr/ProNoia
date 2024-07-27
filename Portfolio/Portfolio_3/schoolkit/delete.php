<?php

include_once("connections/connections.php");


$conn = connection();

if(isset($_POST['delete'])){

    $id = $_POST['ID'];
    $sql = "DELETE FROM student_list WHERE id = '$id'";
    $conn->query($sql) or die (conn->error);
    echo header("location: index.php");
}