using UnityEngine;
using System.Collections;

public class Kosketuslogiikka : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touches.Length <= 0) 
		{
				
						//Jos ruutua ei kosketeta, näin käy.
		
		}

		else
		{
			for(int i = 0; i <Input.touchCount; i++)
			{
				if(this.guiTexture.HitTest(Input.GetTouch(i).position))
				   {

				if(Input.GetTouch(i).phase == TouchPhase.Began)
				{
					this.SendMessage("NappiPainettu");

				}
				if(Input.GetTouch(i).phase == TouchPhase.Ended)
				{
					this.SendMessage("NappiPainamatta");
				}

				}

			}

		}

	
	}
}
