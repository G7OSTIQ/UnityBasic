using System;
using UnityEngine;

public class coin_collertor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        //triggers when this objects connects with a trigger collider.
        //One object needs a Rigidbody both object need a collider for this  to work
        
        Debug.Log($"Collide with {other.name}");
        
        //we are destroying the object we collided with
        Destroy(other.gameObject);
    }
}
