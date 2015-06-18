using UnityEngine;
using System.Collections;

public class DeactiveAmy : MonoBehaviour {

	public int SavedChar;
	
	void Awake()
	{
		SavedChar = PlayerPrefs.GetInt ("SelectedCharacter");
	}

	void Start () 
	{
		if (SavedChar <= 2)
		{
			gameObject.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
