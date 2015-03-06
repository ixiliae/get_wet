using UnityEngine;
using System.Collections;

public class ennemygunDemo : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;
	public float ammo = 10;
	public GameObject player;
	public Transform leader;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	// Update is called once per frame
	void Update()
	{
		
		if (Vector3.Distance(player.transform.position, transform.position) < 20)
			{

				Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
				instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				ammo = ammo - 1f;
			}

	}
	
	
}