using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

[ExecuteInEditMode]
public class TextBaseLevelDesignExample : MonoBehaviour {


	public TextAsset soucre;
	public List<GameObject> cubePrefabList;
		
	public void SetCube(string path){

		if(!path.Contains("level.txt"))return;

		GameObject[] gameobjects = FindObjectsOfType<GameObject>();

		foreach(GameObject g in gameobjects){
			if(g.name == "cube"){
				DestroyImmediate(g);
			}
		}


		Vector3 origin = transform.position;
		float _x = transform.position.x;
		float _z= transform.position.z;

		List<string> lineList = soucre.text.Split('\n').ToList();

		for(int i = 0; i< lineList.Count; i++){

			List<string> cubeTypeList = lineList[i].Split(',').ToList();

			for(int j = 0; j< cubeTypeList.Count; j++){

				int index = 0;

				if(int.TryParse(cubeTypeList[j],out index)){
					GameObject g = (GameObject)Instantiate(cubePrefabList[index],origin + new Vector3(_x,0,_z),Quaternion.identity);
					g.name = "cube";
					g.transform.position = new Vector3(origin.x + _x,origin.y,origin.z + _z);
					_x += 1;
				}
			}

			_x = 0;
			_z += 1;
		}


	}
    /*
	void OnEnable(){
		BeSyncEvent.OnImportCompleteEvent += SetCube;
	}

	void OnDisable(){
		BeSyncEvent.OnImportCompleteEvent -= SetCube;
	}
    */




}
