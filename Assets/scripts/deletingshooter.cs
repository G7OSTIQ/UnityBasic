using UnityEngine;

public class deletingshooter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        //we are destroying the object we collided with
        //Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
