using UnityEngine;
using System.Collections;

public class BeSyncRotater : MonoBehaviour {

	public float x_axis = 0f;
	public float y_axis = 0f;
	public float z_axis = 0f;

	Transform thisTransform;

	public void Rotate(){

		if(thisTransform == null){
			thisTransform = GetComponent<Transform>();
		}

		thisTransform.Rotate(new Vector3(x_axis,y_axis,z_axis));
	}

}
