using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataNoMeja : MonoBehaviour
{
    public string dataNomeja;
    public string datawaktu;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
