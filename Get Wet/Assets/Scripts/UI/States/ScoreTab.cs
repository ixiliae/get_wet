using UnityEngine;
using System.Collections;

public class ScoreTab : State {

	public override void OnEnter()
	{
		
	}
	
	public override void OnUpdate()
	{
		Screen.lockCursor = false;
		Cursor.visible = true;
	}
	
	public override void OnExit()
	{
		
	}
		
	public void CloseTab()
	{
		m_UIManager.ChangeState(m_UIManager.InterfaceName);
		Time.timeScale = 1f;
		Screen.lockCursor = true;
		Cursor.visible = false;
	}

	public void QuitTab()
	{
		m_UIManager.ChangeState(m_UIManager.InterfaceName);
		Time.timeScale = 1f;
		Screen.lockCursor = true;
		Cursor.visible = false;
	}
    public void QuitRespawn()
    {
        Debug.Log("QuitRespawn");
        Time.timeScale = 1f;
        GameObject cam = GameObject.Find("Main Camera 1(Clone)");
        Transform todestroy = cam.GetComponent<WoWcamera>().target;
        Destroy(todestroy.gameObject, 0);
        Destroy(cam, 0);
        NetworkManager netmanag = FindObjectOfType<NetworkManager>();
        netmanag.SpawnPlayer(500, 27, 560);
    
    }
	void LockCursor()
	{
		Screen.lockCursor = true;
		Cursor.visible = false;
	}

	public void PlayTheGame()
	{
		m_UIManager.ChangeState (m_UIManager.InterfaceName);
	}
	
	public void LoadLevel(string levelName)
	{
		Time.timeScale = 1f;
		Application.LoadLevel (levelName);
	}
}

