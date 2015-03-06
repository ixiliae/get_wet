using UnityEngine;
using System.Collections;

public class EnemyAnim : MonoBehaviour {

	// Use this for initialization
	public GameObject enemy;
	public float turningSpeed = 0f;
	
	
	
	void Start () {
		enemy = GameObject.FindGameObjectWithTag("Respawn");	
	}
	
	// Update is called once per frame
	void Update () {

		this.animation.Play ("idle");
		
	}
}
