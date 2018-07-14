using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Clothes[] clothes;

    private SeasonLogic playerSeasonLogic;

    public bool doesHaveCorrectSeasonals;
    public bool doesHaveCorrectColors;
    public bool didPlayerWin;
    public bool isActivePlayer;
    public bool allowKillCheck;

    // Use this for initialization
    void Start ()
    {
        WornClothes();

        foreach (Clothes article in clothes)
        {
            Debug.Log(article);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyUp(KeyCode.C))
        {
            getSeasonValidation();
            Debug.Log("For Player: " + this);
            getColorValidation();
            Debug.Log("For Player: " + this);
            SetVictoryCondition();
            allowKillCheck = true;
        }
    }

    public void WornClothes()
    {
        clothes = GetComponentsInChildren<Clothes>();
    }

    public void getSeasonValidation()
    {
        doesHaveCorrectSeasonals = GetComponent<SeasonLogic>().DetermineCorrectLength(clothes);

    }

    public void getColorValidation()
    {
        doesHaveCorrectColors = GetComponent<ColorCheck>().CheckColors(clothes);

    }

    public void SetVictoryCondition()
    {
        if (doesHaveCorrectSeasonals && doesHaveCorrectColors)
        {
            didPlayerWin = true;
            Debug.Log(this + " Cannot Die!");
        }

        else
        {
            didPlayerWin = false;
            Debug.Log(this + " May Die!");
        }
    }
}
