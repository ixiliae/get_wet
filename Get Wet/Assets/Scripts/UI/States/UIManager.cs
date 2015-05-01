using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public string ViewsPath = "UI/Views/";
	public string MainMenuName = "MainMenu";
	public string OptionsName = "Options";
	public string QuitName = "Quit";
	public string InGameName = "InGame";
	public string InterfaceName = "Interface";
	public string GameOverName = "GameOver";
	public string CharacterSelectName = "CharacterSelect";
	

	// Use this for initialization
	void Start () 
	{
		ChangeState(MainMenuName);
	}	

	State CurrentState;	

	// Update is called once per frame
	void Update () 
	{
		if(CurrentState != null)
		{
			CurrentState.OnUpdate();
		}
	}
	
	public State CreateView(string viewName)
	{
		GameObject go = Instantiate(Resources.Load(viewName)) as GameObject;
		State newState = go.GetComponent<State> ();
		return newState;		                             
 	}
		                             
	 public void ChangeState(string viewName)
	 {
			if(CurrentState != null)		
			{
				CurrentState.OnExit();
			Destroy(CurrentState.gameObject);
			}
			
			State newState = CreateView(ViewsPath + viewName);
			if(newState != null)
			{
				CurrentState = newState;
				CurrentState.transform.SetParent(this.transform);
				CurrentState.transform.localPosition = Vector3.zero;
				CurrentState.transform.localScale = Vector3.one;
				CurrentState.m_UIManager = this;
				CurrentState.OnEnter();
			}
	}

	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
	}
	
}
