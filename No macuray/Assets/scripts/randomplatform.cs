using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomplatform : MonoBehaviour {
	public GameObject platform1;
	public GameObject platform2;
	public GameObject platform3;
	public Transform puntodelanzamiento;
	bool juego;
	//public Text texto;
	public Text textpuntos;
	int puntos;

	public Image gameoverimage;
	public Button tryagainbuton;
	public Button quitbuton;
	public Image tryagainimage;
	public Image quitimage;

	// Use this for initialization
	void Start () {
	
		globalvariables.puntos=0;
		globalvariables.velocidad=0.02f;
	}
	
	// Update is called once per frame
	void Update () {
		textpuntos.text=""+globalvariables.puntos;
		
	}
	void OnTriggerEnter(Collider other){
		int random=Random.Range(1,4);
		//texto.text="r:"+random;
	
		globalvariables.velocidad*=1.01f;
		if(other.tag=="platform"){
			
			Destroy(other.gameObject);
			if(globalvariables.juegoon==true){
			switch (random)
			{
				case 1:GameObject nuevobloque = Instantiate (platform1, puntodelanzamiento.position, transform.rotation);break;

				case 2:
				GameObject nuevobloque2 = Instantiate (platform2, puntodelanzamiento.position, transform.rotation);break;
				
				
				
				case 3:
				GameObject nuevobloque3_2 = Instantiate (platform3, puntodelanzamiento.position, transform.rotation);break;
				

				default:GameObject nuevobloque4 = Instantiate (platform1, puntodelanzamiento.position, transform.rotation);break;

			}
			}//juegotrue
		}


	if(other.tag=="Player"){
		//texto.text="LOOSE";
		globalvariables.juegoon=false;
		gameoverimage.enabled=true;
		tryagainbuton.enabled=true;
		tryagainimage.enabled=true;
		quitbuton.enabled=true;
		quitimage.enabled=true;
	}

	}
}
