using UnityEngine;
using System.Collections;

public class tsunamiDamages : MonoBehaviour {
	
	public float bulletLife = 1.0f;
	private GameObject player;
	PlayerHealth p;
	EnemyHealth e;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Destroy (gameObject, 30);
		this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y,this.transform.position.z+1f);
		
	}
	void OnTriggerEnter(Collider col)
	{
		player = col.gameObject;
		if ((col.gameObject.name == "whitinola") || (col.gameObject.name == "Blackinola"))
		{
			p = player.GetComponent<PlayerHealth>();
			p.TakeDamage(100);
			
			PlayerManager.Instance.AddHealth(0, -100);
		}
		if (col.gameObject.name == "Enemy")
		{
			e = player.GetComponent<EnemyHealth>();
			e.TakeDamage(100);
			
		}
		
	}
}