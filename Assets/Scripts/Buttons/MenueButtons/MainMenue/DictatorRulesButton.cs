using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictatorRulesButton : MonoBehaviour {

    public GameObject dictatorRulesPanel;

    public void OpenPlayerStatsMenue()
    {
        dictatorRulesPanel.SetActive(true);
    }
}
