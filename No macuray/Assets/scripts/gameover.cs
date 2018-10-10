using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour {
	public Button startbuton;
	public Image startimage;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("juegoon")){
			string juegoons=PlayerPrefs.GetString("juegoon");
			if(juegoons=="true"){
				globalvariables.juegoon=true;
			}else{globalvariables.juegoon=false;}
		}else{
			PlayerPrefs.SetString("juegoon","false");
			globalvariables.juegoon=false;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.juegoon==true){
			startimage.enabled=false;
		startbuton.enabled=false;}
	}
	public void tryagain(){
		SceneManager.LoadScene("game");
	}
	public void exit(){
		PlayerPrefs.SetString("juegoon","false");
		Application.Quit();
		
	}
	public void start(){
		PlayerPrefs.SetString("juegoon","true");
		startimage.enabled=false;
		startbuton.enabled=false;
		globalvariables.juegoon=true;
	}
}
