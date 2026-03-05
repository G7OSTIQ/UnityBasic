using UnityEngine;

public class selfdistract : MonoBehaviour
{

    public float timer = 3f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
