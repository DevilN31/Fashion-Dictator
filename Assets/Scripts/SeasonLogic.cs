using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Seasons { Spring, Summer, Fall, Winter }


public class SeasonLogic : MonoBehaviour
{
    public Seasons currentSeason;

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
                    return true;
                else
                    return false;
            case Seasons.Summer:
                if (longClothes == 0 && shortClothes == 4)
                    return true;
                else
                    return false;
            case Seasons.Fall:
                if (longClothes == 3 && shortClothes == 1)
                    return true;
                else
                    return false;
            case Seasons.Winter:
                if (longClothes == 4 && shortClothes == 0)
                    return true;
                else
                    return false;
            default:
                Debug.Log("Somehow default activated");
                return false;
        }
    }

    public void SetCurrentSeasonEnum(Seasons newSeason)
    {
        currentSeason = newSeason;
    }

    public void SetCurrentSeasonString(string newSeason)
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
                Debug.Log("Somehow default activated, did you forget the capital letter?");
                break;
        }
    }
}
