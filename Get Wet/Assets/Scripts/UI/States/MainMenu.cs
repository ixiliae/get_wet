using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : State {

	public string MyIP = "127.0.0.1";

	public override void OnEnter()
	{
		
	}

	public override void OnUpdate()
	{

	}

	public override void OnExit()
	{
		PlayerPrefs.SetString ("DaIP", (MyIP));
		Debug.Log (PlayerPrefs.GetString("DaIP"));
	}

	void Awake()
	{
		Time.timeScale = 1f;
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

	//public void InputIP(string IP)
	//{
	//	MyIP = "1";
	//}
	
	void OnGUI() {
		MyIP = GUI.TextField(new Rect(530, 480, 100, 20),MyIP, 25);


	}
	
}
