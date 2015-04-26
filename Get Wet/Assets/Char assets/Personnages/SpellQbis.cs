using UnityEngine;
using System.Collections;

public class SpellQbis : MonoBehaviour {
	
	// Use this for initialization
	public float bulletLife = 10.0f;
	private GameObject player;
	PlayerHealth p;
	EnemyHealth e;
	
	
	// Update is called once per frame
	void Update () {
		
		Destroy(gameObject, bulletLife);
		
	}
	
	void OnTriggerEnter(Collider col)
	{
		player = col.gameObject;
		
		if (col.gameObject.name == "baseMale 1 1")
		{
			p = player.GetComponent<PlayerHealth>();
			p.TakeDamage(100);
		}
		if (col.gameObject.name == "Enemy")
		{
			e = player.GetComponent<EnemyHealth>();
			e.TakeDamage(100);
		}
		
	}
}
