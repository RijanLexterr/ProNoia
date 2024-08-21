<?php

include_once("../connections/connections.php");


$conn = connection();


if(isset($_POST['submit'])){


  try {
    $Name = $_POST['Name'];
    $Username = $_POST['Username'];
    
     
    $sql = "INSERT INTO user ( `Name`, `Username`) VALUES ('$Name','$Username')";
    //tesst
    $conn->query($sql) or die ($conn->error);
    
    }
    
    //catch exception
    catch(Exception $e) { 
      echo 'Message: ' .$e->getMessage();
    }
} 



?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Student Management System</title>
  <link rel="stylesheet" href="../css/add.css"> 

</head>
<body>





<form class="form" action="" method="post">
    <span class="signup">Add new Member</span>
    <input type="text" placeholder="Full Name" class="form--input" name="Name" id="Name" required>
    <input type="text" placeholder="Username" class="form--input" name="Username" id="Username" required >
     
    <input type="submit" name="submit" class="form--submit" value="Add">
    
   
</form>








</body>
</html>
