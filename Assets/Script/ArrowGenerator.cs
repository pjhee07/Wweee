using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    
    public GameObject ArrowPrefab;
    public float delaytime = 0.5f;

    void Start()
    {
        /*for(int i = 0; i < 10; i++)
        {
        Instantiate(ArrowPrefab, new Vector3(i*2, 5, 0),transform.rotation);
        }*/
    }

    void Update()
    {
        Vector3 position = Vector3.zero;

        position = new Vector3(Random.Range(-9f, 9f), 6, 0);
        Instantiate(ArrowPrefab, position, transform.rotation);
    }
}
