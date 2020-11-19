using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Interaction : MonoBehaviour, IVirtualButtonEventHandler
{
    public Animator anim;
    public Transform Kopi;
    string vbName;

    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }
        anim = Kopi.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "VirtualButton")
        Kopi.transform.Rotate(Vector2.down, 50f * Time.deltaTime);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}