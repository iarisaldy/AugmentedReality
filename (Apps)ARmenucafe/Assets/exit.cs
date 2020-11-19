using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject popup;
    void Start()
    {
       
    }

    public void Up()
    {
       popup.SetActive(true);
    }
    public void batal()
    {
        popup.SetActive(false);
    }

}
