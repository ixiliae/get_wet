using UnityEngine;
using System.Collections;

public class MainMenu : State {
	
	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		
	}
	
	public override void OnExit()
	{

	}

	public void GoToSelect()
	{
		m_UIManager.ChangeState (m_UIManager.CharacterSelectName);
	}

	public void GoToOptionsPage()
	{
		m_UIManager.ChangeState(m_UIManager.OptionsName);
	}

	public void QuitTheGame()
	{
		Application.Quit ();		
	}

}
