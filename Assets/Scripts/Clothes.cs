 
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    //Tomer's addition
    //-------------------------
    const int color_yellow = 0;
    const int color_orange = 1;
    const int color_red = 2;
    const int color_purple = 3;
    const int color_blue = 4;
    const int color_green = 5;

    const int counter_colors_yellow_purple = 0;
    const int counter_colors_orange_blue = 1;
    const int counter_colors_red_green = 2;

    const int hatAcc = 0;
    const int coat = 1;
    const int shirt = 2;
    const int pants = 3;
    const int shoes = 4;

    public int clothType;

    //const int color_warm = 0;
    //const int color_cold = 1;

    public bool warmColor;

    public int clothColor;
    public int counter_colors;
    public int colorTemp;

    ColorsEnum colorsEnum;
    //-------------------------

    public string clothesName;
    public bool isLong;

    public Clothes(string name, bool isItLong)
    {
        clothesName = name;
        isLong = isItLong;
    }

    public bool GetIsLong()
    {
        return isLong;
    }


    //Tomer's addition
    //Sets the color of the clothing item. Also sets what type of counter colors it belongs to, and what it's color temparture, based on it's color.
    //-------------------------
    public void SetColor(int color)
    {
        clothColor = color;

        if (color == color_yellow || color == color_purple)
            counter_colors = counter_colors_yellow_purple;

        else if (color == color_orange|| color == color_blue)
            counter_colors = counter_colors_orange_blue;

        else if (color == color_red|| color == color_green)
            counter_colors = counter_colors_red_green;

        if (color >= 0 && color < 3)
            warmColor = true;
        //colorTemp = color_warm;
        else if (color >= 3)
            warmColor = false;
        //colorTemp = color_cold;
    }

    public void SetType(int type)
    {
        clothType = type;
    }
    //-------------------------
}