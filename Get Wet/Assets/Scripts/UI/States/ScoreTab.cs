using UnityEngine;
using System.Collections;

public class ScoreTab : State {

	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		Screen.lockCursor = false;
		Cursor.visible = true;
	}
	
	public override void OnExit()
	{
		
	}
		
	public void CloseTab()
	{
		if (Input.GetKeyDown (KeyCode.RightShift)) 
		{
			m_UIManager.ChangeState (m_UIManager.InterfaceName);
			Time.timeScale = 1f;
			Screen.lockCursor = true;
			Cursor.visible = false;
		}
	}

	public void QuitTab()
	{
		m_UIManager.ChangeState(m_UIManager.InterfaceName);
		Time.timeScale = 1f;
		Screen.lockCursor = true;
		Cursor.visible = false;
	}
	
	void LockCursor()
	{
		Screen.lockCursor = true;
		Cursor.visible = false;
	}
}

