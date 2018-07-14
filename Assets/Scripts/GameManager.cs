using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player myPlayer;
    public Player[] playerArray;

    public int tryNumber = 0;
    

	// Use this for initialization
	void Start ()
    {
        myPlayer = GetComponentInChildren<Player>();
        myPlayer.isActivePlayer = true;

        myPlayer.GetComponent<SeasonLogic>().SetCurrentSeasonWithString("Summer");

        FindPlayers();

        foreach (Player player in playerArray)
        {
            if (player != null)
            Debug.Log(player);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (myPlayer.allowKillCheck == true)
        {
            if (tryNumber < 2)
                KillRandomPlayer();
            else
                AttemptKillCurrentPlayer();
        }
        myPlayer.allowKillCheck = false;
    }
    // create an array of all the characters that are not the current playable player
    public void FindPlayers()
    {
        playerArray = FindObjectsOfType<Player>();
    }
    // disables players that are wearing wrong clothes, skips dead players
    public void KillRandomPlayer()
    {
        foreach (Player player in playerArray)
        {
            if (player.didPlayerWin == false && player.isActivePlayer == false && player.gameObject.activeSelf)
            {
                player.gameObject.SetActive(false);
                Debug.Log("killed: " + player);
                tryNumber++;
                break;
            }
        }
    }
    // kills player
    public void AttemptKillCurrentPlayer()
    {
        if (myPlayer.didPlayerWin == false)
            myPlayer.gameObject.SetActive(false);
        Debug.Log("killed: " + myPlayer);
    }
}
