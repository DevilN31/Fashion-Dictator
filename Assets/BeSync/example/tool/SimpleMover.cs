using UnityEngine;
using System.Collections;

public class SimpleMover : MonoBehaviour {

	public Vector3 move;

	Transform tr;

	void Awake(){
		tr = transform;
	}


	void Update () {
		tr.Translate(move* Time.deltaTime);
	}
}
