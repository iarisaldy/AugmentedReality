﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject objectRotate;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    public void Rotasi()
    {
        if (rotateStatus == false)
        {
            objectRotate.transform.Rotate(Vector2.down, rotateSpeed * Time.deltaTime);
        }
    }
}
