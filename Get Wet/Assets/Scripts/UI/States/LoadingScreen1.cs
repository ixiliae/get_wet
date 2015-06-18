﻿using UnityEngine;
using System.Collections;

public class LoadingScreen1 : State {

	float t;

	public override void OnEnter()
	{

	}
	
	public override void OnUpdate()
	{
		t += Time.deltaTime;
		if (t > 6.0f) {
			m_UIManager.ChangeState(m_UIManager.MainMenuName);	
		}
	}
	
	public override void OnExit()
	{
	
	}
}
