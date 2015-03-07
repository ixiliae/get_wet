using UnityEngine;
using System.Collections;

public class InGame : State {

	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		
	}
	
	public override void OnExit()
	{
		
	}

	public void AcceptChanges()
	{
		m_UIManager.ChangeState(m_UIManager.InterfaceName);
	}

	public void QuitTheGame()
	{
		m_UIManager.ChangeState (m_UIManager.MainMenuName);
	}
	
	public void LoadUIScene(string levelName)
	{
		Application.LoadLevel (levelName);
	}


}

