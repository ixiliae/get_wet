using UnityEngine;
using System.Collections;

public class LoadingScreen : State {

	float t;
		
	void Update()
	{
		t += Time.deltaTime;
		if (t > 6.0f) {
			m_UIManager.ChangeState(m_UIManager.InterfaceName);	
		}
	}
	

}
