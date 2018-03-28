using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerBodyToWrong : MonoBehaviour {

    public Material playerBodyPart;
    public Text changeText;

    public void ChangeBodyMaterialToWrong()
    {
        playerBodyPart.color = Color.white;
        changeText.text = "Wrong";
    }
}
