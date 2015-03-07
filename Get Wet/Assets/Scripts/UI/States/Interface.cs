using UnityEngine;
using System.Collections;

public class Interface : State {



	public override void OnEnter()
	{
		
	}

	void LockCursor()
	{
		Screen.lockCursor = true;
		Screen.showCursor = false;
	}
	
	public override void OnUpdate()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Screen.lockCursor = true;
			Time.timeScale = 0f;
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




