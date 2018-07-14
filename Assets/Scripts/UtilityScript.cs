using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  UtilityScript
{
    public static Dictionary<ClothColors, string> colorsDic = new Dictionary<ClothColors, string>()
    {
        { ClothColors.Yellow,"#b7af31" },
        { ClothColors.Orange,"#ef4000" },
        { ClothColors.Red,"#781111" },
        { ClothColors.Purple,"#3d2556" },
        { ClothColors.Blue,"#4854a6" },
        { ClothColors.Green,"#33683e" },
    };
}

public enum ClothColors
{
    Yellow,
    Orange,
    Red,
    Purple,
    Blue,
    Green
};


public enum CounterColors
{
    YellowPurple,
    OrangeBlue,
    RedGreen
};

public enum ClothesType
{
    HatAcc,
    Shirt,
    Pants,
    Shoes
}

public enum ColorRules
{
    Monochrome,
    CounterColors,
    WarmColors,
    ColdColors
}
    