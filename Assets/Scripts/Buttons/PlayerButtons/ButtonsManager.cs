using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour {

    public static ButtonsManager instance;

    public List<Hat> playerHats;
    public int currenttHat = 0;

    public List<Shirt> playerShirts;
    public int currentShirt;

    public List<Pants> playerPants;
    public int currentPants;

    public List<Shoe> playerShoes;
    public int currentShoe;

    void Start ()
    {
        if(instance == null)
        {
            instance = this;
        }

        playerHats[0].GetComponent<SpriteRenderer>().enabled = true;
        playerShirts[0].GetComponent<SpriteRenderer>().enabled = true;
        playerPants[0].GetComponent<SpriteRenderer>().enabled = true;
        playerShoes[0].GetComponent<SpriteRenderer>().enabled = true;


    }


}
