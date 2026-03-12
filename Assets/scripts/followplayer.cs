using UnityEngine;

public class followplayer : MonoBehaviour
{
    
    //since we can't assign player in prefab we need to look for it
    public Transform Player;

    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //Check the game object before accessing its transform
        GameObject player_go = GameObject.FindWithTag("Player");
        if (player_go != null)
        {
            Player = player_go.transform;
        }
        //Player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {   
        //If not player stop the function
        //if (Player != null) return;
        
        //carculate the next position to move to
        Vector3 traget = Vector3.MoveTowards(transform.position, 
            Player.position, speed * Time.deltaTime);
        //Move toward the player
        transform.position = traget;
    }
}
