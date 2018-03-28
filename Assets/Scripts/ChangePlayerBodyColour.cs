using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerBodyColour : MonoBehaviour {

    public Material playerBodyPart;
    public Text changeText;

	public void ChangeBodyMaterial()
    {
        playerBodyPart.color = Color.blue;
        changeText.text = "Right";
    }
}
