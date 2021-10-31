using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    public GameObject box;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Circle" || col.gameObject.tag == "Bullet")
        {
            // Debug.Log("Collide with Circle"); // Check collide event
            box.SetActive(false);
            // Aktivasi lagi box setelah deactive 3 detik
            Waiter.Wait(3, () =>
            {
                // Just to make sure by the time we're back to activate it, it still exists and wasn't destroyed.
                if (box != null)
                    box.SetActive(true);
            });
            ScoreManager.scoreValue += 1;
        }
    }
}
