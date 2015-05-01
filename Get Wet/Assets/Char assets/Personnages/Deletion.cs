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

<<<<<<< HEAD
		if ((col.gameObject.name == "whitinola") && col.gameObject.name == "Blackinola")
=======
		if ((col.gameObject.name == "whitinola") || (col.gameObject.name == "Blackinola"))
>>>>>>> origin/master
        {
            p = player.GetComponent<PlayerHealth>();
            p.TakeDamage(20);
			Destroy(gameObject, 0);
        }
        if (col.gameObject.name == "Enemy")
        {
            e = player.GetComponent<EnemyHealth>();
            e.TakeDamage(20);
			Destroy(gameObject, 0);
        }
       
    }
}
