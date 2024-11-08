<?php
// details.php - Show user details or create a new user
include_once("../../connections/db.php");

// Check if we have an ID in the URL
$id = isset($_GET['id']) ? $_GET['id'] : null;

if ($id) {
    // If we have an ID, it's an existing user. Fetch the user data.
    $sql = "SELECT * FROM user WHERE ID = $id";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        $row = $result->fetch_assoc();
        echo "<h1>Edit User Details</h1>";
    } else {
        echo "User not found!";
        exit;
    }
} else {
    // If no ID is provided, it's for a new user.
    echo "<h1>Create New User</h1>";
    $row = ['ID' => '', 'Username' => '', 'Email' => '', 'IsActive' => 1, 'Password' => ''];
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User Details</title>

    <!-- Bootstrap 4 CSS -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
    
    <!-- Link to sidebar.css -->
    <link href="../../css/sidebar.css" rel="stylesheet">

    <!-- Link to custom.css -->
    <link href="../../css/custom.css" rel="stylesheet">

</head>
<body>

    <!-- Side Navbar -->
    <div class="sidebar">
        <h3 class="text-center text-white mb-4">Menu</h3>
        <a href="UserList.php">Users</a>
        <a href="role_list.php">Roles</a>
        <a href="position_list.php">Positions</a>
        <a href="album_list.php">Albums</a>
        <a href="file_list.php">Files</a>
        <a href="user_details.php">User Details</a>
    </div>

    <div class="container">
        <!-- Card-like Container with 40% width -->
        <div class="card card-container">
            <!-- Card Body -->
            <div class="card-body">
                <h2 class="text-center mb-4"><?php echo $id ? "Edit User" : "Create New User"; ?></h2>
                <form action="update_user.php" method="POST" onsubmit="return validateForm()">
                    <input type="hidden" name="id" value="<?php echo $row['ID']; ?>" />

                    <!-- Username -->
                    <div class="form-group">
                        <label for="Username">Username</label>
                        <input type="text" class="form-control" id="Username" name="Username" value="<?php echo $row['Username']; ?>" required />
                    </div>

                    <!-- Email -->
                    <div class="form-group">
                        <label for="Email">Email</label>
                        <input type="email" class="form-control" id="Email" name="Email" value="<?php echo $row['Email']; ?>" required />
                    </div>

                    

                    <!-- Password -->
                    <div class="form-group">
                        <label for="Password">Password</label>
                        <input type="password" class="form-control" id="Password" name="Password" required minlength="8" />
                    </div>

                    <!-- Confirm Password -->
                    <div class="form-group">
                        <label for="ConfirmPassword">Confirm Password</label>
                        <input type="password" class="form-control" id="ConfirmPassword" name="ConfirmPassword" required />
                    </div>

                    <!-- Is Active -->
                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="IsActive" name="IsActive" value="1" <?php echo $row['IsActive'] == 1 ? 'checked' : ''; ?>>
                        <label class="form-check-label" for="IsActive">Is Active</label>
                    </div>

                    <!-- Submit Button -->
                    <button type="submit" class="btn btn-primary">Save Changes</button>
                </form>
            </div>
        </div>
    </div>

    <script>
        // Basic client-side validation
        function validateForm() {
            var password = document.getElementById("Password").value;
            var confirmPassword = document.getElementById("ConfirmPassword").value;
            var email = document.getElementById("Email").value;
            
            // Check if password and confirm password match
            if (password !== confirmPassword) {
                alert("Passwords do not match!");
                return false;
            }

            // Check if password meets the minimum length requirement
            if (password.length < 8) {
                alert("Password must be at least 8 characters long.");
                return false;
            }

            // Basic email validation (if not using the built-in HTML5 validation)
            var emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
            if (!email.match(emailPattern)) {
                alert("Please enter a valid email address.");
                return false;
            }

            return true; // Allow form submission
        }
    </script>

</body>
</html>
