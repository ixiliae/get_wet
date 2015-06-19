using UnityEngine;
using System.Collections;

public class RotateFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 150*Time.deltaTime, 0);
	
	}
}
