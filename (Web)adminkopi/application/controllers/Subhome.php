<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Subhome extends CI_Controller {

	/**
	 * Index Page for this controller.
	 *
	 * Maps to the following URL
	 * 		http://example.com/index.php/welcome
	 *	- or -
	 * 		http://example.com/index.php/welcome/index
	 *	- or -
	 * Since this controller is set as the default controller in
	 * config/routes.php, it's displayed at http://example.com/
	 *
	 * So any other public methods not prefixed with an underscore will
	 * map to /index.php/welcome/<method_name>
	 * @see https://codeigniter.com/user_guide/general/urls.html
	 */

	public function __construct()
    {
        parent::__construct();
        $this->load->model('Pesananmodel');
    }
	public function index()
	{
		$data['status'] = $this->Pesananmodel->getpesananmejasatu()->result();
		$data['allstatus'] = $this->Pesananmodel->getstatus()->result();
		$this->load->view('simplesatu',$data);
	}

	public function edit()
	{
		$id_pesanan = $this->input->post('id');
		$status = $this->input->post('status');
      	$this->Pesananmodel->edit($status, $id_pesanan);
        redirect('submenu');
	}
	

}
