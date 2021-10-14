using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    public GameObject box;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Circle")
        {
            // Debug.Log("Collide with Circle"); // Check collide event
            box.SetActive(false);
            ScoreManager.scoreValue += 1;
        }
    }
}
