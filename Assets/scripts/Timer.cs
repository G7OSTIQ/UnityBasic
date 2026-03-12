using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text uiText;
    public float value_time = 60f;

    // Update is called once per frame
    void Update()
    {
        //this will count down the timer
        
        //value_time -= Time.deltaTime;
        value_time = Mathf.Max(value_time - Time.deltaTime, 0); // a short version of if timer goes below zero       
        uiText.text = $"Timer: {value_time:0}"; //:0 is there to round up the number
        
    }
}
