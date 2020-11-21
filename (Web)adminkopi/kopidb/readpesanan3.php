<?php
include('controller.php');

$sql = "SELECT tbl_pesanan.id_pesanan, tbl_pesanan.menu, tbl_pesanan.porsi , tbl_pesanan.catatan, tbl_status.nama_status FROM tbl_pesanan INNER JOIN tbl_status ON tbl_pesanan.id_status = tbl_status.id_status where tbl_pesanan.no_meja = '3' AND tbl_pesanan.id_status != '5'";

$result = mysqli_query($conn, $sql);

if(mysqli_num_rows($result)>0)
{
	while($row = mysqli_fetch_assoc($result)){
			echo "".$row['id_pesanan'].";".$row['menu']." :".$row['porsi']." (".$row['catatan'].");".$row['nama_status'].";";
		}
}
?>