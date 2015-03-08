using UnityEngine;
using System.Collections;

public class IAnav : MonoBehaviour
{

	public GameObject player;
	public Transform leader;
	float AIspeed = 3.5f;
	bool AImoving = true;
	float AIrotate = 90f;
	public Transform waypoint1;
	public Transform waypoint2;
	public Transform waypoint3;
	int w;
	Vector3[] waypoints;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");		
		waypoints = new Vector3[] {waypoint1.position, waypoint2.position ,waypoint3.position};
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		agent.destination = waypoints[0]; 
		transform.FindChild ("baseMale").animation.Play ("walk");
	}
	void Update () {
		
		if ((Vector3.Distance (player.transform.position, transform.position) < 30)) {
			GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
		} else {
			if (Vector3.Distance(transform.position, waypoints[w]) < 1)
			{
				GetComponent<NavMeshAgent>().SetDestination(waypoints[w = (w + 1) % waypoints.Length]);


			}

		}

					}

}
