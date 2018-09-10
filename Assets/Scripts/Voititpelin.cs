using UnityEngine;
using System.Collections;

public class Voititpelin : MonoBehaviour {
	public static int voitto = 0;
	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player") {
			Time.timeScale = 0;
			voitto = 1;
		}
	}
}
