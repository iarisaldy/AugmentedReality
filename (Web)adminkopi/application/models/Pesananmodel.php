<?php
class Pesananmodel extends CI_Model
{
	public function getpesananstatus()
	{
		$this->db->select("*");
		$this->db->from('tbl_pesanan');
		$this->db->join('tbl_status', 'tbl_pesanan.id_status = tbl_status.id_status');
		return $this->db->get();
	}

	public function getpesananmejasatu()
	{
		$this->db->select("*");
		$this->db->from('tbl_pesanan');
		$this->db->join('tbl_status', 'tbl_pesanan.id_status = tbl_status.id_status');
		$this->db->where('tbl_pesanan.no_meja = 1');
		$this->db->where('tbl_pesanan.id_status != 5');
		return $this->db->get();
	}

	public function getpesananmejadua()
	{
		$this->db->select("*");
		$this->db->from('tbl_pesanan');
		$this->db->join('tbl_status', 'tbl_pesanan.id_status = tbl_status.id_status');
		$this->db->where('tbl_pesanan.no_meja = 2');
		$this->db->where('tbl_pesanan.id_status != 5');
		return $this->db->get();
	}

	public function getpesananmejatiga()
	{
		$this->db->select("*");
		$this->db->from('tbl_pesanan');
		$this->db->join('tbl_status', 'tbl_pesanan.id_status = tbl_status.id_status');
		$this->db->where('tbl_pesanan.no_meja = 3');
		$this->db->where('tbl_pesanan.id_status != 5');
		return $this->db->get();
	}

	public function getpesananmejaempat()
	{
		$this->db->select("*");
		$this->db->from('tbl_pesanan');
		$this->db->join('tbl_status', 'tbl_pesanan.id_status = tbl_status.id_status');
		$this->db->where('tbl_pesanan.no_meja = 4');
		$this->db->where('tbl_pesanan.id_status != 5');
		return $this->db->get();
	}

	public function getstatus()
	{
		$this->db->select("*");
		$this->db->from('tbl_status');
		return $this->db->get();
	}

	public function edit($data,$id)
	{
        $this->db->set('id_status', $data);
		$this->db->where('id_pesanan', $id);
		$this->db->update('tbl_pesanan');

	}

}