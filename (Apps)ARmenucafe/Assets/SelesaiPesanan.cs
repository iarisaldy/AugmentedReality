using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelesaiPesanan : MonoBehaviour
{
    public Text nomor;
    void Start()
    {
        
    }

    public void end()
    {
        if (nomor.text == "001")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/Update1.php");
            SceneManager.LoadScene("Utama");
        }
        if (nomor.text == "002")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/Update2.php");
            SceneManager.LoadScene("Utama");
        }
        if (nomor.text == "003")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/Update3.php");
            SceneManager.LoadScene("Utama");
        }
        if (nomor.text == "004")
        {
            WWW itemsData = new WWW("http://172.20.10.6/kopidb/Update4.php");
            SceneManager.LoadScene("Utama");
        }
    }
}
