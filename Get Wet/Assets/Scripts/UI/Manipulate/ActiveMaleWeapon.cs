using UnityEngine;
using System.Collections;

public class ActiveMaleWeapon : MonoBehaviour {

	public int SavedChar;
	
	void Awake()
	{
		SavedChar = PlayerPrefs.GetInt ("SelectedCharacter");
	}
	
	// Use this for initialization
	void Start () 
	{
		if (SavedChar > 2)
		{
			gameObject.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
