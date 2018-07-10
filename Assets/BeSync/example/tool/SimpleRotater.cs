using UnityEngine;
using System.Collections;

public class SimpleRotater : MonoBehaviour {

	public Vector3 ROT;

	Transform tr;

	void Awake(){
		tr = transform;
	}

	void Update(){
		tr.Rotate(ROT * Time.deltaTime);
	}
}
