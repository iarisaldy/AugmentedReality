using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nomeja : MonoBehaviour
{
    public Text txtbox;
    public Text txtbox1;
    public GameObject DataNo;
    public DataNoMeja Script;

    void Awake()
    {
        DataNo = GameObject.FindGameObjectsWithTag("DataNomeja")[0]as GameObject;
        Script = DataNo.GetComponent<DataNoMeja>();
        if (Script != null)
        {
            txtbox.text = Script.dataNomeja;
            txtbox1.text = Script.datawaktu;
        }
        else
        {
            txtbox.text = "SCAN NO MEJA";
        }
        
    }

}
