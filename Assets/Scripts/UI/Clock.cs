using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {

    [Range(0,1)]
    public float ratio;
    public float newRatio;
    int timePassed;

    public Text timerDisplay;

    void Start ()
    {
        timePassed = (int)Time.time;
	}
	
	void Update ()
    {
       timePassed = (int)Time.time;
        
        ratio = timePassed/60f;

        
        if (ratio > newRatio && ratio <=1)
        {
            newRatio = ratio;
            RotateHandle();
            timerDisplay.text =(60 - timePassed) + "";

        }

        
    }

    void RotateHandle()
    {
        Vector3 test = transform.eulerAngles;

        transform.eulerAngles = test + (Vector3.forward * 6);

    }
}
