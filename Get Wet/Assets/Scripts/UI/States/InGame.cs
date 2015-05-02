using UnityEngine;
using System.Collections;

public class InGame : State {

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

	public void AcceptChanges()
	{
		m_UIManager.ChangeState(m_UIManager.InterfaceName);
		Time.timeScale = 1f;
		Screen.lockCursor = true;
		Cursor.visible = false;
	}

	public void QuitTheGame()
	{
		m_UIManager.ChangeState (m_UIManager.MainMenuName);
		Time.timeScale = 1f;
		Screen.lockCursor = false;
		Cursor.visible = true;
	}
	
	public void LoadUIScene(string levelName)
	{
		Application.LoadLevel (levelName);
	}

	void LockCursor()
	{
		Screen.lockCursor = true;
		Cursor.visible = false;
	}


}

