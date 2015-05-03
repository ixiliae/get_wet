using UnityEngine;
using System.Collections;

public class tsunamiShooter : MonoBehaviour
{
	public Transform projectile;
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

			Transform instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Transform;
			
			
		}
		
	}
	
}		



