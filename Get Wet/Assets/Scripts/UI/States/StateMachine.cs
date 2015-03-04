using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour {

	State CurrentState;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentState != null)
		{
			CurrentState.OnUpdate();
		}
	}
	/*
	public State CreateView(string viewName)
	{
		State newState = Instantiate(Resources.Load(viewName, GameObject) as State;
		return newState;

	}*/

	public void ChangeState(string viewName)
	{
		/*if(CurrentState != null)			{
			CurrentState.OnExit();
			Destroy(CurrentState);
		}

		newState = CreateView(viewName);
		if(newState != null)
		{
			CurrentState = newState;
			CurrentState.transform.SetParent(this);
			CurrentState.transform.localPosition = Vector3.zero;
			CurrentState.transform.localScale = Vector3.one;
			CurrentState.m_UIManager = this as U;
			CurrentState.OnEnter();
		}	*/	
	}

	//
	//CurrentState.OnEnter();
	//CurrentState.OnUpdate();
	//CurrentState.OnExit();
}
