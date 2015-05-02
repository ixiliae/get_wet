using UnityEngine;
using System.Collections;

public class turretDamage : MonoBehaviour {
	
	// Use this for initialization
	public float bulletLife = 1.0f;
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
		if ((col.gameObject.name == "whitinola") || (col.gameObject.name == "Blackinola"))
		{
			p = player.GetComponent<PlayerHealth>();
			p.TakeDamage(1);
			Destroy(gameObject, 0);
			PlayerManager.Instance.AddHealth(0, -1);
		}
		if (col.gameObject.name == "Enemy")
		{
			e = player.GetComponent<EnemyHealth>();
			e.TakeDamage(1);
			Destroy(gameObject, 0);
		}
		
	}
}
