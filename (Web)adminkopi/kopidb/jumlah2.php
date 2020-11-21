<?php
include('controller.php');


$sql = "SELECT SUM(total)as jumlah FROM tbl_pesanan where no_meja = '2' AND id_status ='1'";

$result = mysqli_query($conn, $sql);
while($row = mysqli_fetch_array($result)){
			echo "".$row['jumlah']."";
		}
?>