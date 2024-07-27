<?php

include_once("connections/connections.php");


$conn = connection();


if(isset($_POST['submit'])){


  try {
    $fname = $_POST['firstname'];
    $lname = $_POST['lastname'];
    $gender = $_POST['gender'];
     
    $sql = "INSERT INTO student_list (`first_name`, `last_name`, `gender`) VALUES ('$fname','$lname','$gender')";
    //tesst
    $conn->query($sql) or die ($conn->error);
    echo header("location: index.php");
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
  <link rel="stylesheet" href="css/addstyle.css"> 


</head>
<body>


 <div class="form-update">
  <a href="index.php"><-Back</a>
<form action="" method="post">

<label>First Name</label>
<input type="text" name="firstname" id="firstname">

<label>Last Name</label>
<input type="text" name="lastname" id="lastname">

<label>Gender</label>
<select name="gender" id="gender"><option value="Male">Male</option>
<option value="Female">Female</option></select>


<input type="submit" name="submit" value="Submit Form" class="update-button">


</form>
</div>

</body>
</html>