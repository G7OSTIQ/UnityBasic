using UnityEngine;

public class shooting : MonoBehaviour
{
    public float speed = 50f;

    public Rigidbody myregibody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //We don't need the framerate here
        //Impulse - an explosion force
        myregibody.AddForce(transform.up  * speed, ForceMode.Impulse);
    }
    
    
    
}
