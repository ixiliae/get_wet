using UnityEngine;
using System.Collections;

public class Interface : State {

	public int Myflag;

	public override void OnEnter()
	{

	}
	
	
	public override void OnUpdate()
	{
		Screen.lockCursor = true;
		Cursor.visible = false;

		Myflag = PlayerPrefs.GetInt ("Flag");

		if (Input.GetKeyDown (KeyCode.Mouse0))
		{
			m_UIManager.ChangeState (m_UIManager.InterfaceName);
		}

		if (Input.GetKeyDown (KeyCode.LeftShift))
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

		if (Input.GetKeyDown (KeyCode.Keypad1))
		{
			PlayerManager.Instance.AddKills(0, 1);
			PlayerManager.Instance.AddDeaths(1, 1);
		}

		if (Input.GetKeyDown (KeyCode.Keypad2))
	    {
			PlayerManager.Instance.AddKills(1, 1);
			PlayerManager.Instance.AddDeaths(0, 1);
		}

	}


	public override void OnExit()
	{
		
	}

}




