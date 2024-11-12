using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartrotate : MonoBehaviour
{
  private float rotationspeed = 91f;
    

   
    void Update()
    {
        transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);
    }
}
