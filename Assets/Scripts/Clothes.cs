using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
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
}
