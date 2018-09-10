using UnityEngine;
using System.Collections;

public class Kuolema : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player") {
			Liiketouch.dead = true;
			Liiketouch.deathcooldown = 0.5f;
		}
	}
}
