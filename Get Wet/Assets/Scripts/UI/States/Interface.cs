using UnityEngine;
using System.Collections;

public class Interface : State {



	public override void OnEnter()
	{

	}
	
	
	public override void OnUpdate()
	{
		Screen.lockCursor = true;
		Cursor.visible = false;

		if (Input.GetKeyDown (KeyCode.M))
		{
			m_UIManager.ChangeState (m_UIManager.ScopeName);
		}


		if (Input.GetKeyDown (KeyCode.P))
		{
			Time.timeScale = 0f;
			m_UIManager.ChangeState (m_UIManager.InGameName);
		}

		if (Input.GetKeyDown (KeyCode.Tab))
		{
			Time.timeScale = 0f;
			m_UIManager.ChangeState (m_UIManager.ScoreTabName);
		}
	}

	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	public override void OnExit()
	{
		
	}

}




