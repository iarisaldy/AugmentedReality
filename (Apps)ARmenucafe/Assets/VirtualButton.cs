using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public float rotateSpeed = 50f;
    public GameObject information,objek,popup;
    bool rotateStatus = false;


    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        Deactivate();
        if (vbName == "VirtualButton1")
            Btn1();
        else if (vbName == "VirtualButton2")
            Btn2();
        else if (vbName == "VirtualButton3")
            Btn3();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        rotateStatus = false;
    }
    void Deactivate()
    {
        information.SetActive(false);
        popup.SetActive(false);
        rotateStatus = false;
    }
    void Btn1()
    {
        information.SetActive(true); 
    }
    void Btn2()
    {
        rotateStatus = true;
    }
    void Btn3()
    {
        popup.SetActive(true);
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            objek.transform.Rotate(Vector2.down, rotateSpeed * Time.deltaTime);
        }
    }
}