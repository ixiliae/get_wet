using UnityEngine;
using System.Collections;

public class RisingTide : MonoBehaviour {

	public int MyTide;
		
	void Update()
	{
		MyTide = PlayerPrefs.GetInt ("Tide");
	}

	public void SetActive()
	{
		if (MyTide != 1)		
		{
			gameObject.SetActive(false);
		}
		else 
		{
			gameObject.SetActive (true);
		}
	}
}
