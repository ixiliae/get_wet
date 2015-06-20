using UnityEngine;
using System.Collections;

public class BlueFlag : MonoBehaviour {

	public int MyFLag;
	
	void Update()
	{
		MyFLag = PlayerPrefs.GetInt ("Flag");
	}

	public void SetActive()
	{
		if (MyFLag != 2)		
		{
			gameObject.SetActive(false);
		}
		else 
		{
			gameObject.SetActive (true);
		}
	}
}
