using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCheck : MonoBehaviour {


    public ColorRules currentColorRule;

    public bool CheckColors(Clothes[] clothesToCheck)
    {
        Clothes hatAcc = null;
        Clothes top = null;
        Clothes pants = null;
        Clothes shoes = null;

        foreach (Clothes item in clothesToCheck)
        {
            if (hatAcc == null)
                hatAcc = item;
            else if (top == null)
                top = item;
            else if (pants == null)
                pants = item;
            else if (shoes == null)
                shoes = item;
        }

        switch (currentColorRule)
        {
            case ColorRules.Monochrome:
                if (hatAcc.clothColor == top.clothColor &&
                    top.clothColor == pants.clothColor && pants.clothColor == shoes.clothColor)
                {
                    Debug.Log("Returned true for " + currentColorRule);
                    return true;
                }

                else
                {
                    Debug.Log("Returned false for " + currentColorRule);
                    return false;
                }

            case ColorRules.CounterColors:
                if (hatAcc.counterColors  == top.counterColors &&
                    top.counterColors == pants.counterColors && pants.counterColors == shoes.counterColors)
                {
                    Debug.Log("Returned true for " + currentColorRule);
                    return true;
                }

                else
                {
                    Debug.Log("Returned false for " + currentColorRule);
                    return false;
                }

            case ColorRules.WarmColors:
                if (hatAcc.warmColor == top.warmColor &&
                    top.warmColor == pants.warmColor && pants.warmColor == shoes.warmColor)
                {
                    Debug.Log("Returned true for " + currentColorRule);
                    return true;
                }

                else
                {
                    Debug.Log("Returned false for " + currentColorRule);
                    return false;
                }

            case ColorRules.ColdColors:
                if (hatAcc.warmColor == top.warmColor && top.warmColor == pants.warmColor && 
                    pants.warmColor == shoes.warmColor)
                {
                    Debug.Log("Returned true for " + currentColorRule);
                    return true;
                }

                else
                {
                    Debug.Log("Returned false for " + currentColorRule);
                    return false;
                }

            default:
                Debug.Log("Somehow default activated when the current color rule was checked in the switch");
                return false;
        }
    }
}
