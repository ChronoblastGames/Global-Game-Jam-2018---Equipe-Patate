﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollow : MonoBehaviour {

    float lockPos = 0;

    void Update()
    {
        transform.rotation = Quaternion.Euler(90, lockPos, lockPos);
    }


}
