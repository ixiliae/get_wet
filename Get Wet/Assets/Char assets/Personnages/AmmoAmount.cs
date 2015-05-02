using UnityEngine;
using System.Collections;

public class AmmoAmount : MonoBehaviour {

	public float amount = 10f;
	gunDemo g;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			GameObject obj = GameObject.Find ("Spawnpoint");
			gunDemo Pscript = obj.GetComponent<gunDemo> ();
			Pscript.ammo = amount;
			Pscript.ammo2 = 2;
			Destroy(gameObject);

			PlayerManager.Instance.PickUpAmmo(0, 10);
			PlayerManager.Instance.PickUpAmmo2(0, 2);
		}
	}

}
