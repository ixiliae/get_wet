using UnityEngine;
using System.Collections;

public class Scope : State {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L))
		{
			m_UIManager.ChangeState (m_UIManager.InterfaceName);
		}
	
	}
}
