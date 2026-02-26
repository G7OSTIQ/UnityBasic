using UnityEngine;
using UnityEngine.InputSystem;

public class shooterspawner : MonoBehaviour
{
    
    //The template projectile
    public GameObject shooterpreflap;
    
    // The spawn position -a point in space
    public Transform spawnpoint;
    

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            
            //Create a copy of the projectile
            Instantiate(shooterpreflap, spawnpoint.position, spawnpoint.rotation);
        }

        
    }
}
