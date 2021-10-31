using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box" || other.gameObject.tag == "Wall")
        {
            Destroy(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
