using UnityEngine;
using System.Collections;

public class gunDemo : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
	public float ammo = 10;

    // Update is called once per frame
    void Update()
    {

		if (ammo > 0) {
			if (Input.GetButtonDown ("Fire1")) {
				Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
				instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				this.GetComponent<AudioSource>().Play ();
				ammo = ammo - 1f;
			}
		}
    }


}