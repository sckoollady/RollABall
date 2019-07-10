using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelTwo : MonoBehaviour
{
    // Start is called before the first frame update
     private Vector3 pos1 = new Vector3(29.6f,0.5f,8.15f);
     private Vector3 pos2 = new Vector3(29.6f,0.5f,-9f);
     public float speed = 1.0f;
 
     void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
     }
}
