using UnityEngine;
using System.Collections;

public class AmmoAmount : MonoBehaviour {

	public float amount = 10f;
	gunDemo g;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			GameObject obj = GameObject.Find ("Spawn");
			gunDemo Pscript = obj.GetComponent<gunDemo> ();
			Pscript.ammo = amount;
		}
	}

}
