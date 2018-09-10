using UnityEngine;
using System.Collections;

public class Pistelisaa : MonoBehaviour {



void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player") {
			Score.LisaaPiste();
			gameObject.SetActive(false);
		}
	}
}
