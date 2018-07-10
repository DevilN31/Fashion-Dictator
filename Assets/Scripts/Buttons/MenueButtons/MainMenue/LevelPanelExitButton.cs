using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanelExitButton : MonoBehaviour {

    public GameObject playerStatsMenue;

    public void TurnOfMenue()
    {
        playerStatsMenue.SetActive(false);
    }
}
