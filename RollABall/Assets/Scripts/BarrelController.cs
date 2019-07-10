﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{
     private Vector3 pos1 = new Vector3(13f,0.5f,-8f);
     private Vector3 pos2 = new Vector3(13f,0.5f,8f);
     public float speed = 1.0f;
 
     void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
     }
}