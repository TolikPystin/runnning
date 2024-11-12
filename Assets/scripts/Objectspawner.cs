using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 minposition;
    public Vector3 maxposition;
    public int amount = 10;






    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 randomposition = new Vector3(
                Random.Range(minposition.x, maxposition.x),
                Random.Range(minposition.y, maxposition.y),
                Random.Range(minposition.z, maxposition.z));
            Instantiate(prefab, randomposition, prefab.transform.rotation);


        }
    }

  
}
