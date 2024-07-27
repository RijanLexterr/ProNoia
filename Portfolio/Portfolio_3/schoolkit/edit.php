<?php

include_once("connections/connections.php");


$conn = connection();
$id =  $_GET['ID'];


  $sql =  "SELECT * FROM student_list WHERE id = '$id'";
  $students = $conn->query($sql) or die($conn->error);
  $row = $students->fetch_assoc();

if(isset($_POST['submit'])){


  try {
    $fname = $_POST['firstname'];
    $lname = $_POST['lastname'];
    $gender = $_POST['gender'];
     
    $sql = "UPDATE student_list SET first_name = '$fname', last_name = '$lname' , gender = '$gender' WHERE id = '$id'";
    
    $conn->query($sql) or die ($conn->error);
    echo header("location: details.php?ID=".$id);
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
  <link rel="stylesheet" href="css/style.css"> 


</head>
<body>
 
<form action="" method="post">

<label>First Name</label>
<input type="text" name="firstname" id="firstname" value="<?php echo $row['first_name'];?>">

<label>Last Name</label>
<input type="text" name="lastname" id="lastname" value="<?php echo $row['last_name'];?>">>

<label>Gender</label>
<select name="gender" id="gender"><option value="Male" <?php echo ($row['gender'] == "Male")? 'selected' : '';?>>Male</option>
<option value="Female" <?php echo ($row['gender'] == "Female")? 'selected' : '';?>>Female</option></select>


<input type="submit" name="submit" value="Update">


</form>


</body>
</html>