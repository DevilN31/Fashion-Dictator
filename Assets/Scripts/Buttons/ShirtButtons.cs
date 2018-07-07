using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtButtons : MonoBehaviour {

    public void NextShirt()
    {

        if (ButtonsManager.instance.currentShirt < ButtonsManager.instance.playerShirts.Count - 1)
        {
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].LoadNextShirt(ButtonsManager.instance.currentShirt + 1);
            ButtonsManager.instance.currentShirt++;
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].enabled = false;
        }
        else if (ButtonsManager.instance.currentShirt >= ButtonsManager.instance.playerShirts.Count - 1)
        {
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].LoadNextShirt(0);
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].enabled = false;
            ButtonsManager.instance.currentShirt = 0;
        }

    }

    public void PreviousShirt()
    {

        if (ButtonsManager.instance.currentShirt <= ButtonsManager.instance.playerShirts.Count - 1 && ButtonsManager.instance.currentShirt != 0)
        {
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].LoadNextShirt(ButtonsManager.instance.currentShirt - 1);
            ButtonsManager.instance.currentShirt--;
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].enabled = false;
        }
        else if (ButtonsManager.instance.currentShirt == 0)
        {
            ButtonsManager.instance.currentShirt = ButtonsManager.instance.playerShirts.Count - 1;
            ButtonsManager.instance.playerShirts[0].LoadNextShirt(ButtonsManager.instance.currentShirt);
            ButtonsManager.instance.playerShirts[ButtonsManager.instance.currentShirt].enabled = false;


        }
    }
}
