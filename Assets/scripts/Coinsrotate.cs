using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Coinsrotate : MonoBehaviour
{
   private float rotationspeed = 111f;
    

   
    void Update()
    {
        transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);
    }
}
