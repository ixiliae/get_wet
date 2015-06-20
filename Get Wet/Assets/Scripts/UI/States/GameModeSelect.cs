using UnityEngine;
using System.Collections;

public class GameModeSelect : State {

	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		
	}
	
	public override void OnExit()
	{
		
	}
	
	public void BackToTeam()
	{
		m_UIManager.ChangeState (m_UIManager.TeamSelectName);
	}
	
	public void PlayTheGame()
	{
		m_UIManager.ChangeState (m_UIManager.LoadingScreenName);
	}
	
	public void LoadLevel(string levelName)
	{
		Time.timeScale = 1f;
		Application.LoadLevel (levelName);
	}
}
