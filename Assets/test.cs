﻿using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public Transform t1;
    public Transform t2;
    public GameObject t3;
    public Transform t4;
    public Transform t5;

    void Start()
    {
        if (t3 != null)
            Instantiate(t3);
    }

}
