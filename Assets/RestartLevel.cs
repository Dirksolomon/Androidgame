using UnityEngine;
using System.Collections;

public class RestartLevel : Kosketuslogiikka {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Liiketouch.death == 1) 
		{
			GetComponent<GUITexture>().enabled = true;
			Time.timeScale = 0;
		}
	}
	void NappiPainettu()
	{
		if (this.name == "Uudestaan") 
		{
			Liike.death = 0;
			Time.timeScale = 1;
			Application.LoadLevel("androidpeli");
		}


	}
}
