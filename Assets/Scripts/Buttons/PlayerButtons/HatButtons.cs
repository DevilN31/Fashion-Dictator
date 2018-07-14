using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatButtons : MonoBehaviour
{

    public void NextHat()
    {

        if (ButtonsManager.instance.currenttHat < ButtonsManager.instance.playerHats.Count - 1)
        {
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].LoadNextHat(ButtonsManager.instance.currenttHat + 1);
            ButtonsManager.instance.currenttHat++;
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].enabled = false;
        }
        else if (ButtonsManager.instance.currenttHat >= ButtonsManager.instance.playerHats.Count - 1)
        {
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].LoadNextHat(0);
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].enabled = false;
            ButtonsManager.instance.currenttHat = 0;
        }
        
    }

    public void PreviousHat()
    {

        if (ButtonsManager.instance.currenttHat >= ButtonsManager.instance.playerHats.Count - 1)
        {
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].LoadNextHat(ButtonsManager.instance.currenttHat - 1);
            ButtonsManager.instance.currenttHat--;
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].enabled = false;
        }
        else if (ButtonsManager.instance.currenttHat <= 0)
        {
            ButtonsManager.instance.currenttHat = ButtonsManager.instance.playerHats.Count - 1;
            ButtonsManager.instance.playerHats[0].LoadNextHat(ButtonsManager.instance.currenttHat);
            ButtonsManager.instance.playerHats[ButtonsManager.instance.currenttHat].enabled = false;


        }
    }

}
