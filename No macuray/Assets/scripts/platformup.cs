using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformup : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		//globalvariables.juegoon=false;
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.juegoon==true){
		transform.Translate(0,globalvariables.velocidad,0);
	}
	}
}
