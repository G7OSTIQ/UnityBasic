using System;
using TMPro;
using UnityEngine;

public class coin_collertor : MonoBehaviour
{
    public int score= 10;
    public TMP_Text player_score;
    
    private void OnTriggerEnter(Collider other)
    {
        
        //triggers when this objects connects with a trigger collider.
        //One object needs a Rigidbody both object need a collider for this  to work
        
        Debug.Log($"Collide with {other.name}");
        
        //we are destroying the object we collided with
        Destroy(other.gameObject); 
        score += 10;
        player_score.text = $"Score: {score}";

    }
}
