using UnityEngine;
using System.Collections;

public class BlueFlag : MonoBehaviour {

	public int MyFLag = 2;
	
	void Update()
	{
		MyFLag = PlayerPrefs.GetInt ("Flag");

		if (PlayerPrefs.GetInt("Flag") != 2)		
		{
			gameObject.SetActive(false);
		}
		else 
		{
			gameObject.SetActive (true);
		}
	}

	// public void SetActive()
	// {
	// 	if (PlayerPrefs.GetInt("Flag") != 2)		
	// 	{
	// 		gameObject.SetActive(false);
	// 	}
	// 	else 
	// 	{
	// 		gameObject.SetActive (true);
	// 	}
	// }
}
