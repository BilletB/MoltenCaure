﻿using UnityEngine;
using System.Collections;

public class MainCanvas : MonoBehaviour {

    public static MainCanvas instance;

    public GameObject Place_click;
    public GameObject Tour_Click;


    void Awake()
    {
        if(MainCanvas.instance == null)
        {
            instance = this;
        }

    }

    void Update()
    {
        //Debug.Log(Place_click);
    }


}