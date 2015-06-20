using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public int SelectedChar = 1;
	public int SelectedWeapon = 1;
	public int SelectedTeam = 1;
	public int SelectedGameMode = 1;

	public void SelectCharacter(int characterID)
	{
		SelectedChar = characterID;
		PlayerPrefs.SetInt ("SelectedCharacter", (SelectedChar));
		Debug.Log ("Character " + characterID + " Selected");
	}

	public void SelectWeapon(int WeaponID)
	{
		SelectedWeapon = WeaponID;
		PlayerPrefs.SetInt ("SelectedWeapon", (SelectedWeapon));
		Debug.Log ("Weapon " + WeaponID + " Selected");
	}
	
	public void SelectTeam(int TeamID)
	{
		SelectedTeam = TeamID;
		PlayerPrefs.SetInt ("SelectedTeam", (SelectedTeam));
		Debug.Log ("Team " + TeamID + " Selected");
	}

  	public void SelectGameMode(int GameModeID)
	{
		SelectedGameMode = GameModeID;
		PlayerPrefs.SetInt ("SelectedGameMode", (SelectedGameMode));
		Debug.Log ("Game Mode " + GameModeID + " Selected");
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
