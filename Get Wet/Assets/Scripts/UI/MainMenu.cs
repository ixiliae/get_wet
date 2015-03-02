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

	public void GoToOptionsPage()
	{
		Debug.Log ("Prout");
		m_UIManager.ChangeState(m_UIManager.OptionsName);

	}

	public void QuitTheGame()
	{
		Application.Quit ();		
	}

}
