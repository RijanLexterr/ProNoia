<?php
if(!isset($_SESSION)){
  session_start();
}

if(isset($_SESSION['UserLogin'])){

  echo "<div class='message success'>Welcome ".$_SESSION['UserLogin']. '</div>';
} else{
  echo "<div class='message info'>Welcome Guest</div>";
}

include_once("connections/connections.php");


$conn = connection();


  $sql =  "SELECT * FROM student_list ORDER BY id DESC";
  $students = $conn->query($sql) or die($conn->error);
  $row = $students->fetch_assoc();



?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Student Management System</title>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="stylesheet" href="css/style.css"> 



</head>
<body>
  
<div class="wrapper">
  <h1>Student Management System</h1>

  <br>
  <br>
  <div class="search-container">
<form action="result.php" method="get">
<input type="text" name="search" id = "search" class="search-input">
<button type="submit" class="search-button">Search</button>
</form>
</div>

<div class="button-container">
<?php if(isset($_SESSION['UserLogin'])){?>
  <a href="logout.php">Logout</a>
<?php }else { ?>  
  <a href="login.php">Login</a>

<?php } ?>
  <a href="add.php">Add New</a>
  </div>



  <table>
    <thead class="table-success">
    <tr>
      <th></th>
    <th>First Name</th>
    <th>Last Name</th>
    </tr>
   </thead>
   <tbody> 

<?php do{ ?>
<tr>
  <td width="30"><a href="details.php?ID=<?php echo $row['id'];?>" class="button-small">View</a></td>
  <td><?php echo $row['first_name']; ?></td>
  <td><?php echo $row['last_name']; ?></td>
</tr>

<?php }while($row = $students->fetch_assoc()) ?>


   </tbody>
   
  </table>
 
  </div>
</body>
</html>