using UnityEngine;
using System.Collections;

public class AmmoAmount : MonoBehaviour {

	public float amount = 10f;
	PlayerShooting g;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {

            GameObject p = other.gameObject;
            g = p.GetComponentInChildren<PlayerShooting>();
                g.ammo = 100;
                g.ammo2 = 10;
			
            
		}
	}

}
