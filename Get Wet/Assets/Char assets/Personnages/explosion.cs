using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	
	// Use this for initialization
	public float bulletLife = 10.0f;
	private GameObject player;
	PlayerHealth p;
	EnemyHealth e;
	Object parent;
	public GameObject body;
	public Transform prefab;
	public int damages;
	void Start()
	{
		parent = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
		Destroy(gameObject, bulletLife);
		
	}
	
	void OnTriggerEnter(Collider col)
	{
		Instantiate(prefab, col.transform.position, Quaternion.identity);
		Destroy (gameObject, 0);

			p = col.gameObject.GetComponent<PlayerHealth>();
			p.TakeDamage(damages);
			Destroy(gameObject, 0);
			PlayerManager.Instance.AddHealth(0, -damages);

		if (col.gameObject.name == "Enemy")
		{
			e = col.gameObject.GetComponent<EnemyHealth>();
			e.TakeDamage(damages);
			Destroy(gameObject, 0);
		}
		
	}

}
