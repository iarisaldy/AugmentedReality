using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilihMenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject esteh;
    public GameObject greenteh;
    public GameObject kopi;
    public GameObject genderuo;
    public GameObject seblak;


    public void Scan_NoMeja()
    {
        SceneManager.LoadScene("Scan_NoMeja");
    }
    public void Pemesanan()
    {
        SceneManager.LoadScene("Pemesanan_old");
    }
    public void Makanan()
    {
        SceneManager.LoadScene("Makanan");
    }
    public void Minuman()
    {
        SceneManager.LoadScene("Minuman");
    }
    public void Pilih_Menu()
    {
        SceneManager.LoadScene("Pilih_Kategori");
    }
    public void GreenTeh()
    {
        SceneManager.LoadScene("vb_Greenteh");
    }
    public void EsTeh()
    {
        SceneManager.LoadScene("vb_Esteh");
    }
    public void Kopi()
    {
        SceneManager.LoadScene("vb_Kopi");
    }
    public void Genderuo()
    {
        SceneManager.LoadScene("vb_Genderuo");
    }
    public void Seblak()
    {
        SceneManager.LoadScene("vb_Seblak");
    }
    public void Pitzza()
    {
        SceneManager.LoadScene("vb_Pizza");
    }
    public void Gorengan()
    {
        SceneManager.LoadScene("vb_Gorengan");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Tentang()
    {
        Panel.SetActive(true);
    }
    public void CloseTentang()
    {
        Panel.SetActive(false);
    }
}
