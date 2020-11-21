<?php
include('controller.php');

$no_meja = $_POST["no_mejaPost"];
$menu = $_POST["menuPost"];
$harga = $_POST["hargaPost"];
$porsi = $_POST["porsiPost"];
$total = $_POST["totalPost"];
$catatan = $_POST["CatatanPost"];


$status = '1';

$sql = "INSERT INTO tbl_pesanan(no_meja, menu, harga, porsi, total, catatan, id_status) VALUES ('".$no_meja."','".$menu."','".$harga."','".$porsi."','".$total."','".$catatan."','".$status."')";

$result = mysqli_query($conn, $sql);

?>

