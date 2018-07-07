using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class BeSyncSetMaterial : MonoBehaviour {


	public GameObject target;



	public Material material;

    /*

	void OnEnable(){
		BeSyncEvent.OnPlayModeAgainEvent += OnImportComplete;
	}
	void OnDisable(){
		BeSyncEvent.OnPlayModeAgainEvent -= OnImportComplete;
	}

    */

	public void OnImportComplete(string str){

		if(target != null){

			Renderer[] ren = target.GetComponentsInChildren<Renderer>();
			Debug.Log(ren.Length);
			foreach(Renderer r in ren){
				r.material = material;
			}
		}
	}

}
