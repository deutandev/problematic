using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // public static ObjectPool instance;

    // public List<GameObject> pooledObjects = new List<GameObject>();
    // public int amountToPool;

    // [SerializeField] private GameObject boxPrefab;

    // void Awake()
    // {
    //     if (instance == null)
    //     {
    //         instance = this;
    //     }
    // }
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     amountToPool = Random.Range(10, 20);

    //     for (int i=0; i < amountToPool; i++)
    //     {
    //         GameObject obj = Instantiate(boxPrefab);
    //         obj.SetActive(false);
    //         pooledObjects.Add(obj);
    //     }   
    // }

    // public GameObject GetPooledObject()
    // {
    //     for (int i=0; i < pooledObjects.Count; i++)
    //     {
    //         if (!pooledObjects[i].activeInHierarchy)
    //         {
    //             return pooledObjects[i];
    //         }
    //     }

    //     return null;
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public GameObject prefab;

    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject bottomWall;
    public GameObject topWall;

    private int amount;

    private List<GameObject> pool = new List<GameObject>();

    void Start() 
    {
        amount = Random.Range(10, 20); // Jumlah box acak antara 10-20 box
        for (int i = 0; i < amount; i++) 
        {
            var instance = Instantiate(prefab);
            pool.Add(instance);
            instance.transform.position = RandomizePosition(); // Posisi box acak
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
