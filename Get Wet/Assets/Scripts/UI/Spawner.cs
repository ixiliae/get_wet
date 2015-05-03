using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public int SelectedChar = 1;
	public int SelectedSpawn = 0;
	public int SelectedTeam = 1;

	public void SelectTeam(int teamID)
	{
		SelectedTeam = teamID;
		PlayerPrefs.SetInt ("SelectedTeam", (SelectedTeam));
		Debug.Log ("Team Selected");
	}

	public void SelectCharacter(int characterID)
	{
		SelectedChar = characterID;
		PlayerPrefs.SetInt ("SelectedCharacter", (SelectedChar));
		Debug.Log ("Character Selected");
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
