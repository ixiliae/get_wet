using UnityEngine;
using System.Collections;

public class FlagCaptured : MonoBehaviour {

	public int MyFLag = 1;

	void Update()
	{
		MyFLag = PlayerPrefs.GetInt ("Flag");
	}
	
	public void SetActive()
	{
		if (MyFLag != 1) 
		{
			gameObject.SetActive (false);
		} 
		else 
		{
			gameObject.SetActive (true);
		}
	}
}
