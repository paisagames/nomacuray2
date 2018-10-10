using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burger : MonoBehaviour {
	public AudioSource audioamm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="Player"){
		globalvariables.puntos++;
		audioamm.Play();
		Destroy(this.gameObject);
	}
	}
}
