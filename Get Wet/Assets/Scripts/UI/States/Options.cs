using UnityEngine;
using System.Collections;

public class Options : State {


	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		
	}
	
	public override void OnExit()
	{
		
	}

	public void OnBackPressed()
	{
		Debug.Log ("Prout");
		m_UIManager.ChangeState(m_UIManager.MainMenuName);
	}
}
