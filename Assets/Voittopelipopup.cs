using UnityEngine;
using System.Collections;

public class Voittopelipopup : MonoBehaviour {
	
	void Update () {
		if (Voititpelin.voitto == 1) {
						GetComponent<GUITexture> ().enabled = true;
				}
	}
}
