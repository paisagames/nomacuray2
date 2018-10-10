using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instucciones : MonoBehaviour {
	public Image left;
	public Image right;
	bool instruccionesbool;
	int touchesd;
	int touchesi;
	// Use this for initialization
	void Start () {
		touchesd=0;
		touchesi=0;
		instruccionesbool=false;
		if(PlayerPrefs.HasKey("instruccionesd")){
			left.enabled=false;
			right.enabled=false;
			instruccionesbool=false;
		}else{
			PlayerPrefs.SetString("instruccionesd","instrucciones");
		
				left.enabled=true;
				right.enabled=true;
				instruccionesbool=true;
			}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	public void quitaderecha(){
		if(instruccionesbool==true){
			
				right.enabled=false;
			
		}

	}
	public void quitaizquierda(){
		if(instruccionesbool==true){
			
			left.enabled=false;
		
		}

	}
}
