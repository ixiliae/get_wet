using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public int SelectedChar = 1;
	public int SelectedSpawn = 0;
	public int SelectedTeam = 1;

	public void SelectWeapon(int WeaponID)
	{
		SelectedTeam = WeaponID;
		PlayerPrefs.SetInt ("SelectedWeapon", (SelectedTeam));
		Debug.Log ("Weapon Selected");
	}

	public void SelectCharacter(int characterID)
	{
		SelectedChar = characterID;
		PlayerPrefs.SetInt ("SelectedCharacter", (SelectedChar));
		Debug.Log ("Character" + characterID + "Selected");
	}	
	
//  	public void SelectPlace(int SpawnID)
//	{
//		SelectedSpawn = SpawnID;
//		PlayerPrefs.SetInt ("SelectedSpawn", (SelectedSpawn));
//		Debug.Log ("Spawn Selected");
//	}













	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
