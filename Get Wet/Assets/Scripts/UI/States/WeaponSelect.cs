using UnityEngine;
using System.Collections;

public class WeaponSelect : State {

	public override void OnEnter()
	{

	}
	
	public override void OnUpdate()
	{
		
	}
	
	public override void OnExit()
	{
		
	}

	public void BackToCharacter()
	{
		m_UIManager.ChangeState (m_UIManager.CharacterSelectName);
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



