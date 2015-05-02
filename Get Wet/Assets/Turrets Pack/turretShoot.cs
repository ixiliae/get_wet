using UnityEngine;
using System.Collections;

public class turretShoot : MonoBehaviour
{
	public Transform projectile;
	public float speed = 20;
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
			if (Vector3.Distance (player.transform.position, transform.position) < 20) {
				transform.parent.LookAt(leader);
				Transform instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Transform;
				instantiatedProjectile.Rotate(90,0,0);	

			
		}

	}
	
}		