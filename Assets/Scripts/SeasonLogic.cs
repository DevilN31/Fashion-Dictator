
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Seasons { Spring, Summer, Fall, Winter }


public class SeasonLogic : MonoBehaviour
{
    private Seasons currentSeason;

    public bool DetermineCorrectLength(List<Clothes> clothes)
    {
        int longClothes = 0;
        int shortClothes = 0;

        foreach(Clothes article in clothes)
        {
            if (article.GetIsLong())
                longClothes++;
            else
                shortClothes++;
        }

        switch (currentSeason)
        {
            case Seasons.Spring:
                if (longClothes == 1 && shortClothes == 3)
                {
                    Debug.Log("Returned true for spring 1 long 3 short");
                    return true;
                }
                else
                {
                    Debug.Log("Returned false for spring");
                    return false;
                }
            case Seasons.Summer:
                if (longClothes == 0 && shortClothes == 4)
                {
                    Debug.Log("Returned true for summer 0 long 4 short");
                    return true;
                }
                else
                {
                    Debug.Log("Returned false for summer");
                    return false;
                }
            case Seasons.Fall:
                if (longClothes == 3 && shortClothes == 1)
                {
                    Debug.Log("Returned true for fall 3 long 1 short");
                    return true;
                }
                else
                {
                    Debug.Log("Returned false for fall");
                    return false;
                }
            case Seasons.Winter:
                if (longClothes == 4 && shortClothes == 0)
                {
                    Debug.Log("Returned true for winter 4 long 0 short");
                    return true;
                }
                else
                {
                    Debug.Log("Returned false for winter");
                    return false;
                }
            default:
                Debug.Log("Somehow default activated when the current season was checked in the switch");
                return false;
        }
    }

    public void SetCurrentSeasonWithEnum(Seasons newSeason)
    {
        currentSeason = newSeason;
    }

    public void SetCurrentSeasonWithString(string newSeason)
    {
        switch (newSeason)
        {
            case "Summer":
                currentSeason = Seasons.Summer;
                break;
            case "Spring":
                currentSeason = Seasons.Spring;
                break;
            case "Winter":
                currentSeason = Seasons.Winter;
                break;
            case "Fall":
                currentSeason = Seasons.Fall;
                break;
            default:
                Debug.Log("Somehow default activated when setting season, did you forget the capital letter?");
                break;
        }
    }

    public Seasons GetCurrentSeason()
    {
        return currentSeason;
    }
}
