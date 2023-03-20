using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    UImaneger uiManager;
    void Start()
    {
        uiManager = FindObjectOfType<UImaneger>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -0.1f, 0);

        if(transform.position.y < -6f)
        {
          Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<UImaneger>().DecrementHP();
        Destroy(gameObject);
    }
}
