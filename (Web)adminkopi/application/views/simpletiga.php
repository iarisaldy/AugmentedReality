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

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition skin-blue sidebar-mini fixed">
<div class="wrapper">

  <header class="main-header">
    <!-- Logo -->
    <a href="<?php echo base_url("home"); ?>" class="logo">
      <!-- mini logo for sidebar mini 50x50 pixels -->
      <span class="logo-mini"><b>KEDAI</b>123</span>
      <!-- logo for regular state and mobile devices -->
      <span class="logo-lg"><b>Admin</b>KEDAI</span>
    </a>
    <!-- Header Navbar: style can be found in header.less -->
    <nav class="navbar navbar-static-top">
      <!-- Sidebar toggle button-->
      <a href="#" class="sidebar-toggle" data-toggle="push-menu" role="button">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </a>

      <div class="navbar-custom-menu">
        <ul class="nav navbar-nav">
          <!-- User Account: style can be found in dropdown.less -->
          <li class="dropdown user user-menu">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
              <img src="<?php echo base_url(); ?>assets/dist/img/user2-160x160.jpg" class="user-image" alt="User Image">
              <span class="hidden-xs">Admin</span>
            </a>
            <ul class="dropdown-menu">
              <!-- User image -->
              <li class="user-header">
                <img src="<?php echo base_url(); ?>assets/dist/img/user2-160x160.jpg" class="img-circle" alt="User Image">
              </li>
              <!-- Menu Footer-->
              <li class="user-footer">
                <div class="pull-left">
                  <a href="<?php echo site_url('auth/logout');?>" class="btn btn-default btn-flat">Sign out</a>
                </div>
              </li>
            </ul>
          </li>
        </ul>
      </div>
    </nav>
  </header>
  <!-- Left side column. contains the logo and sidebar -->
  <aside class="main-sidebar">
    <!-- sidebar: style can be found in sidebar.less -->
    <section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="user-panel">
        <div class="pull-left image">
          <img src="<?php echo base_url(); ?>assets/dist/img/user2-160x160.jpg" class="img-circle" alt="User Image">
        </div>
        <div class="pull-left info">
          <p>Admin</p>
        </div>
      </div>
      <ul class="sidebar-menu" data-widget="tree">
        <li class="treeview active">
          <a href="<?php echo base_url('Home'); ?>">
            <i class="fa fa-dashboard"></i> <span>Menu</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="<?php echo base_url('home'); ?>"><i class="fa fa-circle-o"></i>All Pesanan</a></li>
             <li><a href="<?php echo base_url('subhome'); ?>"><i class="fa fa-circle-o"></i>Meja 1</a></li>
              <li><a href="<?php echo base_url('mejadua'); ?>"><i class="fa fa-circle-o"></i>Meja 2</a></li>
              <li><a href="<?php echo base_url('mejatiga'); ?>"><i class="fa fa-circle-o"></i>Meja 3</a></li>
            <li><a href="<?php echo base_url('mejaempat'); ?>"><i class="fa fa-circle-o"></i>Meja 4</a></li>
          </ul>
        </li>
      </ul>
    </section>
    <!-- /.sidebar -->
  </aside>

  <!-- Content Wrapper. Contains page content -->
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
              <table class="table table-hover">
                <tr>
                  <th>No Meja</th>
                  <th>Menu</th>
                  <th>Harga</th>
                  <th>Porsi</th>
                  <th>Total</th>
                  <th>Status</th>
                  <th></th>
                </tr>
                <?php foreach ($status as $data){ ?>
                <tr>
                  <td><?php echo $data->no_meja; ?></td>
                  <td><?php echo $data->menu; ?></td>
                  <td><?php echo $data->harga; ?></td>
                  <td><?php echo $data->porsi; ?></td>
                  <td><?php echo $data->total; ?></td>
                  <td>
                  <form action="<?php echo base_url(). 'home/edit'; ?>" method="post">
                    <input type="hidden" name="id" value="<?php echo $data->id_pesanan; ?>" />
                    <select class="form-control select2" name="status">
                      <option selected="selected" ><?php echo $data->nama_status; ?></option>
                      <?php foreach ($allstatus as $datastatus): ?>
                      <option value="<?php echo $datastatus->id_status; ?>"> <?php echo $datastatus->nama_status; ?></option>
                      <?php endforeach; ?>
                    </select>
                  <!-- <select name="id_status" class="select2 form-control" style="width: 50%;">
                    <?php foreach ($allstatus as $datastatus): ?>
                      <option
                      <?php if ($datastatus->id_status == $datastatus->id_status) {
                        echo 'selected="selected"';
                      } ?>
                          value="<?php echo $datastatus->id_status; ?>"><?php echo $datastatus->nama_status; ?>
                      </option>
                    <?php endforeach; ?>
                  </select> -->

                  </td>
                  <td>
                    <td> <button type="submit">Konfirmasi</button> </td>
                  </td>
                  </form>
                </tr>
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
<!-- ./wrapper -->

<!-- Modal -->



<!-- jQuery 3 -->
<script src="<?php echo base_url(); ?>assets/bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="<?php echo base_url(); ?>assets/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- Slimscroll -->
<script src="<?php echo base_url(); ?>assets/bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src="<?php echo base_url(); ?>assets/bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="<?php echo base_url(); ?>assets/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="<?php echo base_url(); ?>assets/dist/js/demo.js"></script>
</script>
</body>
</html>
