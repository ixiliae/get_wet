using UnityEngine;
using System.Collections;

public class Interface : State {



	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			m_UIManager.ChangeState (m_UIManager.InGameName);

		}
	}

	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	public override void OnExit()
	{
		
	}

	public void AcceptChanges()
	{
		m_UIManager.ChangeState(m_UIManager.InterfaceName);
	}

}




