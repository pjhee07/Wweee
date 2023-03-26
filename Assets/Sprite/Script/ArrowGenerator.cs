using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    
    public GameObject ArrowPrefab;
    public float delaytime = 0.1f;
    float span = 0f;

    void Start()
    {
        /*for(int i = 0; i < 10; i++)
        {
        Instantiate(ArrowPrefab, new Vector3(i*2, 5, 0),transform.rotation);
        }*/
    }

    void Update()
    {
        span += Time.deltaTime;

        if (span > delaytime)
        {
        Vector3 position = new Vector3(Random.Range(-9f, 9f), 6, 0);
        Instantiate(ArrowPrefab, position, transform.rotation);
        span = 0;
        }
    }
}
