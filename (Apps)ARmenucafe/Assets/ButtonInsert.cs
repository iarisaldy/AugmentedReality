using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonInsert : MonoBehaviour
{
    public Text InsertNomeja;
    public Text InsertMenu;
    public Text InsertHarga;
    public Text InsertPorsi;
    public Text InsertTotal;
    public Text InsertCatatan;

    string CreatePesananURL = "http://172.20.10.6/kopidb/insertpesanan.php";
    void Start()
    {

    }
    public void Go()
    {
        CreatePesanan(InsertNomeja.text, InsertMenu.text, InsertHarga.text, InsertPorsi.text, InsertTotal.text , InsertCatatan.text);
        SceneManager.LoadScene("Pemesanan_old");
    }
    public void CreatePesanan(string no_meja, string menu, string harga, string porsi, string total , string catatan)
    {
        WWWForm form = new WWWForm();
        form.AddField("no_mejaPost", no_meja);
        form.AddField("menuPost", menu);
        form.AddField("hargaPost", harga);
        form.AddField("porsiPost", porsi);
        form.AddField("totalPost", total);
        form.AddField("CatatanPost", catatan);
        WWW www = new WWW(CreatePesananURL, form);
    }
}
