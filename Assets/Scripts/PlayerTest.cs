using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour {

    public Clothes[] playerClothes;
    public bool isColorsCurrect;
    public bool isSeasonCurrect;
    public bool isWon;
    
    // Use this for initialization
	void Start ()
    {
        playerClothes = GetComponentsInChildren<Clothes>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {

            isColorsCurrect = GetComponent<ColorCheck>().CheckColors(playerClothes);
            isSeasonCurrect = GetComponent<SeasonLogic>().DetermineCorrectLength(playerClothes);

            if (isSeasonCurrect && isColorsCurrect)
                isWon = true;
            else
                isWon = false;

           Debug.Log("Did I win? " + isWon);
        }
		
	}
}
