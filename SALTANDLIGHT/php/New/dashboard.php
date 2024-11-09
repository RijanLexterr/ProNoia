<?php
// dashboard.php - Dashboard page with a table for files grouped by album and date, and a simple user list

include_once("../../connections/db.php");

// Fetch the number of files per album grouped by date
$sql_files_by_album_and_date = "
    SELECT a.Label AS album_name, DATE(f.UploadedDate) AS upload_date, COUNT(f.ID) AS file_count
    FROM Album a
    LEFT JOIN Files f ON a.ID = f.AlbumID
    GROUP BY a.ID, DATE(f.UploadedDate)
    ORDER BY a.ID, upload_date";
$result_files_by_album_and_date = $conn->query($sql_files_by_album_and_date);

// Fetch the list of users with their roles
$sql_users_roles = "
    SELECT u.ID, u.Username, r.Label AS role
    FROM user u
    LEFT JOIN UserRole ur ON u.ID = ur.UserID
    LEFT JOIN Role r ON ur.RoleID = r.ID";
$result_users_roles = $conn->query($sql_users_roles);

// Prepare data for the files list (Files per Album by Date)
$files_by_album_and_date = [];

while ($row = $result_files_by_album_and_date->fetch_assoc()) {
    $files_by_album_and_date[] = [
        'album_name' => $row['album_name'],
        'upload_date' => $row['upload_date'],
        'file_count' => (int) $row['file_count'] // Convert file count to integer
    ];
}

// Prepare data for the users list
$users = [];

while ($row = $result_users_roles->fetch_assoc()) {
    $users[] = [
        'username' => $row['Username'],
        'role' => $row['role']
    ];
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dashboard</title>

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
        <a href="dashboard.php">Dashboard</a>
        <a href="user_list.php">Users</a>
        <a href="role_list.php">Roles</a>
        <a href="position_list.php">Positions</a>
        <a href="album_list.php">Albums</a>
        <a href="file_list.php">Files</a>
        <a href="user_details.php">User Details</a>
        
        <!-- Logout Button -->
        <div class="text-center mt-4">
            <button class="logout-btn" onclick="window.location.href='logout.php'">Logout</button>
        </div>
    </div>

    <div class="container" style="margin-left: 250px; padding-top: 20px;">
        <h1 class="text-center mb-4">Dashboard</h1>

        <!-- Files Grouped by Album and Date Table -->
        <div class="card mb-4">
            <div class="card-body">
                <h3 class="card-title">Files Grouped by Album and Date</h3>
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>Album</th>
                            <th>Upload Date</th>
                            <th>File Count</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php if (count($files_by_album_and_date) > 0): ?>
                            <?php foreach ($files_by_album_and_date as $row): ?>
                                <tr>
                                    <td><?php echo htmlspecialchars($row['album_name']); ?></td>
                                    <td><?php echo htmlspecialchars($row['upload_date']); ?></td>
                                    <td><?php echo $row['file_count']; ?></td>
                                </tr>
                            <?php endforeach; ?>
                        <?php else: ?>
                            <tr>
                                <td colspan="3" class="text-center">No files found</td>
                            </tr>
                        <?php endif; ?>
                    </tbody>
                </table>
            </div>
        </div>

        <!-- List of Users and Their Roles -->
        <div class="card">
            <div class="card-body">
                <h3 class="card-title">Users and Their Roles</h3>
                <ul class="list-group">
                    <?php foreach ($users as $user): ?>
                        <li class="list-group-item">
                            <strong><?php echo htmlspecialchars($user['username']); ?></strong> - <?php echo htmlspecialchars($user['role']); ?>
                        </li>
                    <?php endforeach; ?>
                </ul>
            </div>
        </div>
    </div>

    <!-- Bootstrap and jQuery for the Hamburger Menu -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.bundle.min.js"></script>

    <script>
        // Toggle the sidebar on and off when the hamburger icon is clicked
        $('#menuToggle').click(function() {
            $('.sidebar').toggleClass('active');
        });
    </script>

</body>
</html>
