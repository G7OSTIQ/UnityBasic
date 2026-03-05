using UnityEngine;

public class followplayer : MonoBehaviour
{
    
    //since we can't assign player in prefab we need to look for it
    public Transform Player;

    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {   //carculate the next position to move to
        Vector3 traget = Vector3.MoveTowards(transform.position, 
            Player.position, speed * Time.deltaTime);
        //Move toward the player
        transform.position = new Vector3();
    }
}
