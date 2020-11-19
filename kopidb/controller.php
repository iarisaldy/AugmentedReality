<?php
$serverName = "localhost";
$username = "root";
$password = "";
$dbName = "kedai123";

$conn = new mysqli($serverName,$username,$password,$dbName);
if(!$conn)
	{
		die("Connect Failed".mysqli_connect_error());
	}
?>