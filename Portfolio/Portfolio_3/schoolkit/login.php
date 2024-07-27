<?php
if(!isset($_SESSION)){
    session_start();
  }

include_once("connections/connections.php");


$conn = connection();

if(isset($_POST['login'])){

$username = $_POST['username'];
$password = $_POST['password'];

$sql = "SELECT * FROM student_users WHERE username = '$username' AND password = '$password'";

$user = $conn->query($sql) or die ($conn->error);
$row = $user->fetch_assoc();
$total = $user->num_rows;
 


if($total > 0){


$_SESSION['UserLogin'] = $row['username'];
$_SESSION['Access'] = $row['access'];

echo header("location: index.php");
}else{
    echo "<div class='message warning'>No user found.</div> ";
}
}
?>

<!DOCTYPE html>
<html lang="en">
<head>

  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Student Management System</title>
  <link rel="stylesheet" href="css/loginstyle.css"> 

</head>
<body id = "formlogin">
    <div class="login-container">
<h2>Login Page</h2>  
<br>





<div class="form-logo"><img src="img/pronoialogo.png" alt="" srcset=""></div>
<form action="" method="post">

<div class="form-element">
<label>Username</label>
<input type="text" name="username" id="username" autocomplete="off" placeholder="Enter User name" required>
</div>
<div class="form-element">
<label>Password</label>
<input type="password" name="password" id="password" placeholder="Enter Password" required>
</div>
<button type="submit" name="login">Login</button>

<a href="index.php" id="backlogin" style="
letter-spacing: 2px;
text-decoration: none;
font-size: 20px;margin-top:2rem;"><-Guest</a>
</form>

</div>
</body>
</html>