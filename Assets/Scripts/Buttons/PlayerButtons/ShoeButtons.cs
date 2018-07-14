using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeButtons : MonoBehaviour {

    public void NextShoe()
    {

        if (ButtonsManager.instance.currentShoe < ButtonsManager.instance.playerShoes.Count - 1)
        {
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].LoadNextShoe(ButtonsManager.instance.currentShoe + 1);
            ButtonsManager.instance.currentShoe++;
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].enabled = false;
        }
        else if (ButtonsManager.instance.currentShoe >= ButtonsManager.instance.playerShoes.Count - 1)
        {
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].LoadNextShoe(0);
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].enabled = false;
            ButtonsManager.instance.currentShoe = 0;
        }

    }

    public void PreviousShoe()
    {

        if (ButtonsManager.instance.currentShoe <= ButtonsManager.instance.playerShoes.Count - 1 && ButtonsManager.instance.currentShoe != 0)
        {
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].LoadNextShoe(ButtonsManager.instance.currentShoe - 1);
            ButtonsManager.instance.currentShoe--;
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].enabled = false;
        }
        else if (ButtonsManager.instance.currentShoe <= 0)
        {
            ButtonsManager.instance.currentShoe = ButtonsManager.instance.playerShoes.Count - 1;
            ButtonsManager.instance.playerShoes[0].LoadNextShoe(ButtonsManager.instance.currentShoe);
            ButtonsManager.instance.playerShoes[ButtonsManager.instance.currentShoe].enabled = false;


        }
    }
}
