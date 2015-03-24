using UnityEngine;
using System.Collections;

public class Deletion : MonoBehaviour {

	// Use this for initialization
    public float bulletLife = 5.0f;
	
	// Update is called once per frame
	void Update () {
        
        Destroy(gameObject, bulletLife);
	}
}
