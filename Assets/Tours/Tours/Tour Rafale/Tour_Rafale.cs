﻿using UnityEngine;
using System.Collections;

public class Tour_Rafale : Tour
{

    public void Start()
    {
        cooldown = 0.5f;
        //Le mode_attaque devrait toujours être en false
        mode_attaque = false;
        aoe = false;
    }
}