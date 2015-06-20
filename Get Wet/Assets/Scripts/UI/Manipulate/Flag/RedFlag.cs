using UnityEngine;
using System.Collections;

public class RedFlag : MonoBehaviour {

	public int MyFLag = 3;
	
	void Update()
	{
		MyFLag = PlayerPrefs.GetInt ("Flag");
	}
	
	public void SetActive()
	{
		if (MyFLag != 3)		
		{
			gameObject.SetActive(false);
		}
		else 
		{
			gameObject.SetActive (true);
		}
	}
}
