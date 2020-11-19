<style type="text/css">
  #sitebar{
    background: black ;
  }
</style>

  <aside class="main-sidebar" id="sitebar">
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
          </ul>
        </li>
        <li class="treeview">
          <a href="<?php echo base_url('Home'); ?>">
            <i class="fa fa-dashboard"></i> <span>Pemesanan</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
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