using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMakanan : MonoBehaviour
{
    public string inputID;
    public string inputNama;
    public string inputharga;

    string CreateMakananURL = "http://192.168.0.103/kopidb/insertnomeja.php";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) CreateMakanan(inputID, inputNama, inputharga);
    }
    public void CreateMakanan(string id_makanan,string nama_makanan,string harga)
    {
        WWWForm form = new WWWForm();
        form.AddField("idmakananPost", id_makanan);
        form.AddField("namamakananPost", nama_makanan);
        form.AddField("hargaPost", harga);
        WWW www = new WWW(CreateMakananURL, form);
    }
}
