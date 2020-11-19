using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vbinteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject firstPanel, secondPanel, kopi, teh, greenteh, seblak;

    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "VirtualButtonChange")
            VirtualButtonChange();
        else if (firstPanel.activeInHierarchy)
        {
            Deactivate();
            if (vbName == "VirtualButton1")
                Btn1();
            else if (vbName == "VirtualButton2")
                Btn2();
        }
        else
        {
            Deactivate();
            if (vbName == "VirtualButton1")
                Btn3();
            else if (vbName == "VirtualButton2")
                Btn4();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    void VirtualButtonChange()
    {
        if (firstPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
        }
        else
        {
            firstPanel.SetActive(true);
            secondPanel.SetActive(false);
        }
    }

    void Deactivate()
    {   
        kopi.SetActive(false);
        greenteh.SetActive(false);
        teh.SetActive(false);
        seblak.SetActive(false);
    }

    void Btn1()
    {
        greenteh.SetActive(true);
    }

    void Btn2()
    {
        kopi.SetActive(true);
    }

    void Btn3()
    {
        teh.SetActive(true);
    }

    void Btn4()
    {
        seblak.SetActive(true);
    }
}