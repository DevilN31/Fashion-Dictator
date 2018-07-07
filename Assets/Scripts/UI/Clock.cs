using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

    public int ratio;
    public float newRatio;
    int timePassed;
    Vector3 targetAngles;

    // Use this for initialization
    void Start ()
    {
        timePassed = (int)Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
       timePassed = (int)Time.time;
        ratio = 60 - ((int)timePassed/60);

        if(ratio >= 0)
        Debug.Log(timePassed);

        if (ratio > newRatio)
        {
            newRatio = ratio;
           // Rotate(newRatio);
        }

        
    }

    void Rotate(float ratio)
    {

        targetAngles = transform.eulerAngles + 60f * Vector3.forward;
        print(targetAngles);

    }
}
