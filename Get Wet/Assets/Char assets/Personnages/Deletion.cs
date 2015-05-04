using UnityEngine;
using System.Collections;

public class Deletion : MonoBehaviour {

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

            p = col.gameObject.GetComponent<PlayerHealth>();
            p.TakeDamage(20);
			Destroy(gameObject, 0);
			PlayerManager.Instance.AddHealth(0, -20);
        

            e = col.gameObject.GetComponent<EnemyHealth>();
            e.TakeDamage(20);
			Destroy(gameObject, 0);
        
       
    }
}
