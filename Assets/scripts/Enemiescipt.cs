using UnityEngine;

public class Enemiescipt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy whatever has collided with
            Destroy(other.gameObject);
        }
        
        //Will destroy me
        Destroy(gameObject);
    }
}
