using UnityEngine;
using System.Collections;

public class waterDamages : MonoBehaviour {

	public float bulletLife = 10.0f;
	private GameObject player;
	PlayerHealth p;
	EnemyHealth e;
	Object parent;
	public GameObject body;
	public Transform prefab;
	public int damages;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		Instantiate(prefab, col.transform.position, Quaternion.identity);

		
		p = col.gameObject.GetComponent<PlayerHealth>();
		p.TakeDamage(damages);

		PlayerManager.Instance.AddHealth(0, -damages);

		
	}
	
}
