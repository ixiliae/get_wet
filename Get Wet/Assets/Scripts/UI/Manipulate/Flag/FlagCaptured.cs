using UnityEngine;
using System.Collections;

public class FlagCaptured : MonoBehaviour {

	public int MyFLag = 1;

	void Update()
	{
		MyFLag = PlayerPrefs.GetInt ("Flag");

		if (PlayerPrefs.GetInt("Flag") != 1) 
		{
			gameObject.SetActive (false);
		} 
		else 
		{
			gameObject.SetActive (true);
		}
	}
	
	//public void SetActive()
	//{
	//	if (MyFLag != 1) 
	//	{
	//		gameObject.SetActive (false);
	//	} 
	//	else 
	//	{
	//		gameObject.SetActive (true);
	//	}
	//}
}
