﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public bool CollideOrNot = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollideOrNot = true;
    }
}
