<?php

include_once("../connections/connections.php");


$conn = connection();


if(isset($_POST['submit'])){


  try {
    $Username = $_POST['Username'];   
    $AttendanceDate =  date("Y-m-d H:i:s");    
   
    //Check if current day is sunday
    if( date('D') == 'Sun')
    { 
      $sql = "INSERT INTO attendance ( `Username`, `AttendanceDate`) VALUES ('$Username','$AttendanceDate')";
      $conn->query($sql) or die ($conn->error);
    
    } else
    {
      echo "<script type='text/javascript'>alert('You can only log on Sunday Service');</script>";
      header("Refresh:0");
      return;
      

    }

     
    
    
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
  <link rel="stylesheet" href="../css/attendance.css"> 

</head>
<body>

<div class="form-container">
  <form class="form" action="" method="post">
    <svg
      xmlns="http://www.w3.org/2000/svg"
      class="lock-icon"
      width="1em"
      height="1em"
      viewBox="0 0 24 24"
      stroke-width="0"
      fill="currentColor"
      stroke="currentColor"
    >
      <path
        d="M12 2C9.243 2 7 4.243 7 7v3H6a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2v-8a2 2 0 0 0-2-2h-1V7c0-2.757-2.243-5-5-5zM9 7c0-1.654 1.346-3 3-3s3 1.346 3 3v3H9V7zm4 10.723V20h-2v-2.277a1.993 1.993 0 0 1 .567-3.677A2.001 2.001 0 0 1 14 16a1.99 1.99 0 0 1-1 1.723z"
      ></path>
    </svg>
    <input class="toggle-input" id="toggle-checkbox" type="checkbox" />
    <p class="form-title">Welcome back</p>
    <p class="form-sub-title">
      Glad to see you in our Sunday Service.
    </p>

    <div class="login-card">
      <div class="field-container">
        <input placeholder="" class="input" type="text"  name="Username" id="Username" required/>
        <span class="placeholder">Username</span>
      </div>
    
      
      <input type="submit" name="submit" class="btn btn-label" value="Member Login">
    </div>
     
      
    </div>
  </form>
</div>













</body>
</html>
