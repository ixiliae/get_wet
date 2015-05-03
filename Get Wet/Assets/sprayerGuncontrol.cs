using UnityEngine;
using System.Collections;

public class sprayerGuncontrol : MonoBehaviour {
	public Rigidbody projectile;
	public float speed = 20;
	public float ammo = 10;
	public float speed2 = 20;
	public float ammo2 = 10;
	public Rigidbody projectile2;
	
	// Update is called once per frame
	void Update()
	{
		
		if (ammo > 0) {
			if (Input.GetButtonDown ("Fire1")) {
				Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
				Rigidbody instantiatedProjectile4 = Instantiate (projectile, transform.position * (0.0050f), transform.rotation ) as Rigidbody;
				Rigidbody instantiatedProjectile5 = Instantiate (projectile, transform.position * (1.0050f), transform.rotation ) as Rigidbody;

				instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				

				instantiatedProjectile5.velocity = transform.TransformDirection (new Vector3 (-0.001f, 0, speed));

				instantiatedProjectile4.velocity = transform.TransformDirection (new Vector3 (0.002f, 0, speed));
				this.GetComponent<AudioSource> ().Play ();
				ammo = ammo - 1f;
				PlayerManager.Instance.AddAmmo(0, -3);
			}
		}
		if (ammo2 > 0) {
			if (Input.GetButtonDown ("Fire2")) {
				Rigidbody instantiatedProjectile2 = Instantiate (projectile2, transform.position, transform.rotation) as Rigidbody;
				instantiatedProjectile2.velocity = transform.TransformDirection (new Vector3 (0, 0, speed2));
				this.GetComponent<AudioSource>().Play ();
				ammo2 = ammo2 - 1f;
				PlayerManager.Instance.AddAmmo2(0, -1);
			}
		}
	}
	

	}

