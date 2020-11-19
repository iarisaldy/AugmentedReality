using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPilih : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject btn_Greenteh;
    public GameObject btn_Esteh;
    public GameObject btn_Seblak;
    public GameObject btn_kopi;
    public GameObject btn_next;
    public GameObject btn_prev;
    public int nomor = 0;
    public void next()
    {
        nomor++;
        if (nomor == 0)
        {
            btn_Greenteh.SetActive(true);
            btn_Seblak.SetActive(false);
            btn_Esteh.SetActive(false);
            btn_kopi.SetActive(false);
        }
        if (nomor == 1)
        {
            btn_Greenteh.SetActive(false);
            btn_Seblak.SetActive(true);
            btn_Esteh.SetActive(false);
            btn_kopi.SetActive(false);
        }
        if (nomor == 2)
        {
            btn_Greenteh.SetActive(false);
            btn_Seblak.SetActive(false);
            btn_Esteh.SetActive(true);
            btn_kopi.SetActive(false);

        }
        if (nomor == 3)
        {
            btn_Greenteh.SetActive(false);
            btn_Seblak.SetActive(false);
            btn_Esteh.SetActive(false);
            btn_kopi.SetActive(true);
            btn_prev.SetActive(true);
            btn_next.SetActive(false);
        }
    }
    public void prev()
    {
        nomor--;
        if(nomor == 2)
        {
            btn_Greenteh.SetActive(false);
            btn_Seblak.SetActive(false);
            btn_Esteh.SetActive(true);
            btn_kopi.SetActive(false);
        }
        if (nomor == 1)
        {
            btn_Greenteh.SetActive(false);
            btn_Seblak.SetActive(true);
            btn_Esteh.SetActive(false);
            btn_kopi.SetActive(false);
        }
        if (nomor == 0)
        {
            btn_Greenteh.SetActive(true);
            btn_Seblak.SetActive(false);
            btn_Esteh.SetActive(false);
            btn_kopi.SetActive(false);
            btn_prev.SetActive(false);
            btn_next.SetActive(true);
        }
    }
}
