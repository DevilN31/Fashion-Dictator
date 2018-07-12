using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsButton : MonoBehaviour {

    public GameObject playerStatsMenue;

    public void OpenPlayerStatsMenue()
    {
        playerStatsMenue.SetActive(true);
    }
}
