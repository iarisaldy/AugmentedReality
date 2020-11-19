using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeletePesanan : MonoBehaviour
{
    public Text Deleteidpesanan;

    string DeletePesananURL = "http://172.20.10.6/kopidb/deletepesanan.php";
    void Start()
    {

    }
    public void Go()
    {
        Delete(Deleteidpesanan.text);
        SceneManager.LoadScene("Pemesanan_old");
    }
    public void Delete(string id_pesanan)
    {
        WWWForm form = new WWWForm();
        form.AddField("id_pesananDelete", id_pesanan);
        WWW www = new WWW(DeletePesananURL, form);
    }
}
