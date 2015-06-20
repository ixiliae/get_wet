using UnityEngine;
using System.Collections;

public class WaterDamage : MonoBehaviour {

	// Use this for initialization
    private GameObject player;
    PlayerHealth p;
    EnemyHealth e;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        player = col.gameObject;

        p = col.gameObject.GetComponent<PlayerHealth>();
        p.TakeDamage(100);
    
    }
}
