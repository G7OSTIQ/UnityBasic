using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class morden_movement : MonoBehaviour
{
    
    
    public float speed = 10f;
    public Rigidbody myshipbody;
    private Vector3 direction = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       


}

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
            
        }else if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
            
        }else if (Keyboard.current.wKey.isPressed)
        {
            direction.z = 1;
            
        }else if (Keyboard.current.sKey.isPressed)
        {
            direction.z = -1;
            
        }
        direction.Normalize(); //set the movement at same speed
    }
    
    
    //Fix update runs at 50fps
    private void FixedUpdate()
    {
        
        //adjust movement speed
        myshipbody.linearVelocity = direction * speed;

        //checks if there's squar movement
        //If zero = no movement
        if (direction.sqrMagnitude > 0.1f)
        {
            //adjust rotation movement
            myshipbody.rotation = Quaternion.LookRotation(direction);
        }
    }
}
