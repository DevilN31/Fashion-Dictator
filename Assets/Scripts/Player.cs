using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Clothes> clothes = new List<Clothes>();

	// Use this for initialization
	void Start ()
    {
        WornClothes();
        Debug.Log(clothes);
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void WornClothes()
    {
        clothes.AddRange(GetComponentsInChildren<Clothes>());
    }
}
