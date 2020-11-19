<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Admin Kedai</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="<?php echo base_url(); ?>assets/bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="<?php echo base_url(); ?>assets/bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="<?php echo base_url(); ?>assets/bower_components/Ionicons/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="<?php echo base_url(); ?>assets/dist/css/AdminLTE.min.css">
  <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
  <link rel="stylesheet" href="<?php echo base_url(); ?>assets/dist/css/skins/_all-skins.min.css">
  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
  <!-- jQuery 3 -->
  <script type= "text/javascript" src="<?php echo base_url(); ?>assets/bower_components/jquery/dist/jquery.min.js"></script>
  <!-- dataTable -->
  <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css">
</head>
<body class="hold-transition skin-blue sidebar-mini fixed">
<div class="wrapper">
  <?php $this->load->view("footer.php") ?>


  <?php $this->load->view("sitebar.php") ?>
<div>
  <div class="content-wrapper">

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-md-12">
          <div class="box">
            <div class="box-header">
              <h3 class="box-title">PEMESANAN</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body table-responsive no-padding">
              <table id="myTable" class="table table-hover">
                <thead>
                  <tr>
                    <th>No Meja</th>
                    <th>Menu</th>
                    <th>Harga</th>
                    <th>Porsi</th>
                    <th>Total</th>
                    <th>Catatan</th>
                    <th>Status</th>
                    <th>Update</th>
                  </tr>
                </thead>
                <tbody>
                <?php foreach ($status as $data){ ?>
                <tr>
                  <td><?php echo $data->no_meja; ?></td>
                  <td><?php echo $data->menu; ?></td>
                  <td><?php echo $data->harga; ?></td>
                  <td><?php echo $data->porsi; ?></td>
                  <td><?php echo $data->total; ?></td>
                  <td><?php echo $data->catatan; ?></td>
                  <td>
                  <form action="<?php echo base_url(). 'home/edit'; ?>" method="post">
                    <input type="hidden" name="id" value="<?php echo $data->id_pesanan; ?>" />
                    <select id="id" class="form-control select2" name="status">
                      <option selected="selected" ><?php echo $data->nama_status; ?></option>
                      <?php foreach ($allstatus as $datastatus): ?>
                      <option value="<?php echo $datastatus->id_status; ?>"> <?php echo $datastatus->nama_status; ?></option>
                      <?php endforeach; ?>
                    </select>
                  </td>
                  <td> <button type="submit">Konfirmasi</button> </td>
                  </form>
                </tr>
                <tbody>
                <?php } ?>
              </table>
            </div>
          </div>
        </div>
      </div>
    </section>
  </div>
  <footer class="main-footer">
    <div class="pull-right hidden-xs">
      <b>Version</b> 2.4.0
    </div>
    <strong>Copyright &copy; 2019 <a href="https://adminlte.io">UISI</a>.</strong> INFORMATIKA
    UISI.
  </footer>
</div>
<script src="<?php echo base_url(); ?>assets/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- Slimscroll -->
<script src="<?php echo base_url(); ?>assets/bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src="<?php echo base_url(); ?>assets/bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="<?php echo base_url(); ?>assets/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="<?php echo base_url(); ?>assets/dist/js/demo.js"></script>
<!-- dataTable -->
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.js"></script>
<script type="text/javascript">
$(document).ready( function () {
    $('#myTable').DataTable();
} );
</script>
</body>
</html>
