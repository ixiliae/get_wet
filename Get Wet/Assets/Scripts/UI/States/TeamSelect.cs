using UnityEngine;
using System.Collections;

public class TeamSelect : State {

	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		
	}
	
	public override void OnExit()
	{
		
	}
	
	public void BackToWeapon()
	{
		m_UIManager.ChangeState (m_UIManager.WeaponSelectName);
	}
	
	public void GoToGameMode()
	{
		m_UIManager.ChangeState (m_UIManager.GameModeSelectName);
	}
	
	public void LoadLevel(string levelName)
	{
		Time.timeScale = 1f;
		Application.LoadLevel (levelName);
	}
}
