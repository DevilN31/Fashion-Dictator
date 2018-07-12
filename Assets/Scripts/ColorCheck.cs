using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCheck : MonoBehaviour {

    static int monochrome = 0;
    static int counterColors = 1;
    static int warmColors = 2;
    static int coldColors = 3;

    int currentColorRule;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool CheckColors(Clothes[] clothesToCheck)
    {

        Clothes hatAcc = null;
        Clothes coat = null;
        Clothes shirt = null;
        Clothes pants = null;
        Clothes shoes = null;

        foreach (Clothes item in clothesToCheck)
        {
            if (hatAcc == null)
                hatAcc = item;
            else if (coat == null)
                coat = item;
            else if (shirt == null)
                shirt = item;
            else if (pants == null)
                pants = item;
            else if (shoes == null)
                shoes = item;
        }

        switch (currentColorRule)
        {
            case 0:
                if (hatAcc.clothColor == coat.clothColor && coat.clothColor == shirt.clothColor && shirt.clothColor == pants.clothColor && pants.clothColor == shoes.clothColor)
                    return true;
                    else return false;

            case 1:
                if (hatAcc.counter_colors == coat.counter_colors && coat.counter_colors == shirt.counter_colors && shirt.counter_colors == pants.counter_colors && pants.counter_colors == shoes.counter_colors)
                    return true;
                else return false;

            case 2:
                if (hatAcc.warmColor == coat.warmColor && coat.warmColor == shirt.warmColor && shirt.warmColor == pants.warmColor && pants.warmColor == shoes.warmColor)
                    return true;
                else return false;

            case 3:
                if (hatAcc.warmColor == coat.warmColor && coat.warmColor == shirt.warmColor && shirt.warmColor == pants.warmColor && pants.warmColor == shoes.warmColor)
                    return true;
                else return false;

            default:
            return false;
        }
        return false;
    }
}
