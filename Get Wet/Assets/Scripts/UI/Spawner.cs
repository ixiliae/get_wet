using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public int SelectedChar = 1;
	public int SelectedGameMode = 0;
	public int SelectedWeapon = 1;

	public void SelectWeapon(int WeaponID)
	{
		SelectedWeapon = WeaponID;
		PlayerPrefs.SetInt ("SelectedWeapon", (SelectedWeapon));
		Debug.Log ("Weapon Selected");
	}

	public void SelectCharacter(int characterID)
	{
		SelectedChar = characterID;
		PlayerPrefs.SetInt ("SelectedCharacter", (SelectedChar));
		Debug.Log ("Character" + characterID + "Selected");
	}	
	
  	public void SelectGameMode(int GameModeID)
	{
		SelectedGameMode = GameModeID;
		PlayerPrefs.SetInt ("SelectedGameMode", (SelectedGameMode));
		Debug.Log ("Game Mode Selected");
	}







	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
