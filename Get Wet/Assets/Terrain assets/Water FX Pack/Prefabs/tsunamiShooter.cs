using UnityEngine;
using System.Collections;

public class tsunamiShooter : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 50;
	public GameObject projectile2;
	public GameObject player;
	public Transform leader;
	
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Tsunami")) {

			Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
			
		}
		
	}
	
}		



