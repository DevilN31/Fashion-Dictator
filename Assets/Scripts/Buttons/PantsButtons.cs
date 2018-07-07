using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsButtons : MonoBehaviour {

    public void NextPants()
    {

        if (ButtonsManager.instance.currentPants < ButtonsManager.instance.playerPants.Count - 1)
        {
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].LoadNextPants(ButtonsManager.instance.currentPants + 1);
            ButtonsManager.instance.currentPants++;
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].enabled = false;
        }
        else if (ButtonsManager.instance.currentPants >= ButtonsManager.instance.playerPants.Count - 1)
        {
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].LoadNextPants(0);
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].enabled = false;
            ButtonsManager.instance.currentPants = 0;
        }

    }

    public void PreviousPants()
    {

        if (ButtonsManager.instance.currentPants <= ButtonsManager.instance.playerPants.Count - 1 && ButtonsManager.instance.currentPants != 0)
        {
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].LoadNextPants(ButtonsManager.instance.currentPants - 1);
            ButtonsManager.instance.currentPants--;
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].enabled = false;
        }
        else if (ButtonsManager.instance.currentPants <= 0)
        {
            ButtonsManager.instance.currentPants = ButtonsManager.instance.playerPants.Count - 1;
            ButtonsManager.instance.playerPants[0].LoadNextPants(ButtonsManager.instance.currentPants);
            ButtonsManager.instance.playerPants[ButtonsManager.instance.currentPants].enabled = false;


        }
    }
}
