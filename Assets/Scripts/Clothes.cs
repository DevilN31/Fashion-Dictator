 
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clothes : MonoBehaviour
{
    public string clothesName;
    public bool isLong;
    public bool warmColor;
    public ClothColors clothColor;
    public CounterColors counterColors;
    public ClothesType clothesType;
    private Color myColor;
    
    /*
    public Clothes(string name, bool isItLong)
    {
        clothesName = name;
        isLong = isItLong;
    }
    */
    public bool GetIsLong()
    {
        return isLong;
    }


   // Sets cloth color 
   // Sets Counter Colors group
    public void SetColorAndCounterGroup(ClothColors color)
    {
        //set cloth color
        clothColor = color;

        //set counterColorGroup
        if (color == ClothColors.Yellow || color == ClothColors.Purple)
            counterColors = CounterColors.YellowPurple;

        else if (color == ClothColors.Orange || color == ClothColors.Blue)
            counterColors = CounterColors.OrangeBlue;

        else if (color == ClothColors.Red || color == ClothColors.Green)
            counterColors = CounterColors.RedGreen;

        //Set warm or cold clothes
        if ((int)color >= 0 && (int)color < 3)
            warmColor = true;
        else if ((int)color >= 3)
            warmColor = false;
    }

    // Set cloth type
    public void SetType(ClothesType type)
    {
        clothesType = type;
    }

    void Start()
    {
        ChangeColorTest(UtilityScript.colorsDic[clothColor]);
        
    }
   
    void Update()
    {
        SetColorAndCounterGroup(clothColor);
        ChangeColorTest(UtilityScript.colorsDic[clothColor]);

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(clothesName + ", isLong: " + isLong + ", Color: " + clothColor + ", ConterColorGroup: " + counterColors + ", ClothesType: " + clothesType + ", WarmColor: " + warmColor);
        }
    }

    void ChangeColorTest(string colorValue)
    {
        ColorUtility.TryParseHtmlString(colorValue, out myColor);
        GetComponent<Image>().color = myColor;
    }
}