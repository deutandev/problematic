using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool08 : MonoBehaviour
{
    public GameObject prefab;

    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject bottomWall;
    public GameObject topWall;

    public GameObject circle;
    public float minDistance = 1.0f; // Jarak minimal box dari circle saat dispawn

    private int amount;

    private List<GameObject> pool = new List<GameObject>();

    void Start() 
    {
        Vector2 randomPos;
        amount = Random.Range(10, 20); // Jumlah box acak antara 10-20 box
        for (int i = 0; i < amount; i++) 
        {
            var instance = Instantiate(prefab);
            pool.Add(instance);
            // Acak posisi box, jika jarak dengan circle kurang dari minDistance acak lagi terus
            do
            {
                randomPos = RandomizePosition();
            } while (Vector2.Distance(randomPos, circle.transform.position) < minDistance);
            instance.transform.position = randomPos; // Posisi box acak
        }
    }

    public GameObject Instantiate(Vector2 position) 
    {
        foreach (var item in pool) 
        {
            item.transform.position = new Vector2(10, 12);
            item.SetActive(true);
            return item;
        }
        return null;
    }

    private Vector2 RandomizePosition()
    {
        float wallWidth = 1; // Nilai untuk memberi margin dari dinding
        float xMin = leftWall.transform.position.x + wallWidth;
        float xMax = rightWall.transform.position.x - wallWidth;
        float yMin = bottomWall.transform.position.y + wallWidth;
        float yMax = topWall.transform.position.y - wallWidth;

        float xPos = Random.Range(xMin, xMax);
        float yPos = Random.Range(yMin, yMax);

        return new Vector2(xPos, yPos);
    }
}
