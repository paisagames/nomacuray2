using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour {
	bool derecha;
	bool izquierda;
	public Transform pelota;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {if(globalvariables.juegoon==true){
		if(derecha==true){
			transform.Translate(0.2f,0,0);
			pelota.Rotate(0,0,-15f);
		}
		if(izquierda==true){
			transform.Translate(-0.2f,0,0);
			pelota.Rotate(0,0,15f);
		}
		if(transform.position.x<-4.4f){
			transform.position=new Vector3(4.08f,transform.position.y,transform.position.z);
		}
		if(transform.position.x>4.08f){
			transform.position=new Vector3(-4.4f,transform.position.y,transform.position.z);
		}
		
	}
		
	}
	public void izquierdaDown(){
		izquierda=true;
	}
	public void izquierdaUp(){
		izquierda=false;
	}
	public void derechaDown(){
	derecha=true;
	}
	public void derechaUp(){
	derecha=false;
	}
}
