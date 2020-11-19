using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_menu : MonoBehaviour
{
    public GameObject popup;
    public GameObject informasi;
    bool InformationStatus = false;

    public void POPUP()
    {
        popup.SetActive(true);
    }
    public void POPUPclose()
    {
        popup.SetActive(false);
    }
    public void info()
    {
        if (InformationStatus == false)
        {
            InformationStatus = true;
            aktiv();
        }
        else
        {
            InformationStatus = false;
            tdkaktiv();
        }
    }
    void aktiv()
    {
            informasi.SetActive(true);
    }
    void tdkaktiv()
    {
            informasi.SetActive(false);    
    }
}
