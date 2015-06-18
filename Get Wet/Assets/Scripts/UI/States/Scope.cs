using UnityEngine;
using System.Collections;

public class Scope : State {

	public void BackToInferface()
	{
		m_UIManager.ChangeState (m_UIManager.InterfaceName);
	}





	// Use this for initialization
	void Start () {
	
	}

	public override void OnUpdate () {
		if (Input.GetKeyDown (KeyCode.Mouse1))
		{
			m_UIManager.ChangeState (m_UIManager.InterfaceName);
		}
	
	}
}
