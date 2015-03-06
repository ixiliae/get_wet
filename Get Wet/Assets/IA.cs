using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {
	public GameObject player;
	public Transform leader;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Vector3.Distance(player.transform.position, transform.position) < 20)
		{			
			this.transform.LookAt(leader);
		}
	}
}
