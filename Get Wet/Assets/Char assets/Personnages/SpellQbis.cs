using UnityEngine;
using System.Collections;

public class SpellQbis : MonoBehaviour {
	
	// Use this for initialization
	public float bulletLife = 10.0f;
	private GameObject player;
	PlayerHealth p;
	EnemyHealth e;
    public int damages;
	
	// Update is called once per frame
	void Update () {
		
		Destroy(gameObject, bulletLife);
		
	}
	
	void OnTriggerEnter(Collider col)
	{
		player = col.gameObject;
		
	
			p = player.GetComponent<PlayerHealth>();
			p.TakeDamage(1000);
		

			e = player.GetComponent<EnemyHealth>();
			e.TakeDamage(1000);
		
		
	}
}
