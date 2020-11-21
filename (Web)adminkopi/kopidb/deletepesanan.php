<?php
include('controller.php');

$id_pesanan = $_POST["id_pesananDelete"];


$sql = "DELETE FROM tbl_pesanan WHERE id_status = '1' AND id_pesanan = '".$id_pesanan."'";
$result = mysqli_query($conn, $sql);

?>