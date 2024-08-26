<?php


include_once("Entities/memberEntity.php");




if(isset($_POST['submit'])){

  $member = new member();
  $member->set_name($_POST['Name']);
  $member->set_username($_POST['Username']);
  $member->set_id($_POST['id']);
  memberUpsert($member);

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
    <input type="text"  name="id" id="id" style="display:none;">
    <input type="text" placeholder="Full Name" class="form--input" name="Name" id="Name" required>
    <input type="text" placeholder="Username" class="form--input" name="Username" id="Username" required >
     
    <input type="submit" name="submit" class="form--submit" value="Add">
    
   
</form>








</body>
</html>
