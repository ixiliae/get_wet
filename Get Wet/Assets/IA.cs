using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {
	public GameObject player;
	public Transform leader;
	float AIspeed = 3.5f;
	bool AImoving = true;
	float AIrotate = 90f;
	PlayerHealth p;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		p = player.GetComponent <PlayerHealth>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if ((Vector3.Distance(player.transform.position, transform.position)< 30)&& (Vector3.Distance(player.transform.position, transform.position)> 3)){
			transform.LookAt (leader);
			transform.position += transform.forward * AIspeed * Time.deltaTime;
			transform.FindChild("baseMale").animation.Play("walk");
		} else
			StartCoroutine (Patrol ());

	}
	IEnumerator Patrol()
	{
		if (AImoving)
		{
			transform.position += transform.forward * AIspeed * Time.deltaTime;
			yield return new WaitForSeconds(1.5f);
			AImoving = false;
			transform.FindChild("baseMale").animation.Play("walk");
		}
		transform.Rotate(0, AIrotate * Time.deltaTime, 0);
		yield return new WaitForSeconds(1.5f);
		AImoving = true;
	}
}
