using UnityEngine;

public class spawner : MonoBehaviour
{
    
    public GameObject objecttospawn;
    //an arrary is a collection of data type
    public Transform[] spawnpoints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //invoke calls it once
        //InvokeRepeating calls it more the once
        InvokeRepeating("Spawn", 1f, 2f);
    }

    // Spawn a thing in the scene at a point
    private void Spawn()
    {
        //1. Get a random number
        int index = Random.Range(0, spawnpoints.Length); // .length means it count from 0-4 from the list
        Transform point = spawnpoints[index];
        
        //2. Spawn an item on the spawn point
        Instantiate(objecttospawn, point.position, point.rotation); 
    }
}
