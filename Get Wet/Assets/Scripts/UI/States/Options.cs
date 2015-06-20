using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options : State {

	public Slider MainSlider;
	public bool VolumeOnOff;


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
		m_UIManager.ChangeState(m_UIManager.MainMenuName);
	}

	public void OnVolumeChange()
	{
		AudioListener.volume = MainSlider.value;
		Debug.Log (AudioListener.volume);
	}

	//public void VolumeBool()
	//{
	//	if (VolumeOnOff = false) {
	//		AudioListener.enabled = false;
	//	}
	//}
}
