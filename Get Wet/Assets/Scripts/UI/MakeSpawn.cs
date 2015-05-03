using UnityEngine;
using System.Collections;

public class MakeSpawn : MonoBehaviour {

	public GameObject WhiteBa = GameObject.Find("whiteBazooka");
	public GameObject BlackBa = GameObject.Find("blackBazooka");
	public GameObject WhiteGr = GameObject.Find("whiteGrenade");
	public GameObject BlackGr = GameObject.Find("blackGrenade");
//	public GameObject Character5 = GameObject.Find("whiteShotgun");
//	public GameObject Character6 = GameObject.Find("blackShotgun");
	

	public int SavedChar = 1;
	public int SavedSpawn = 0;
	public int SavedTeam = 1;



	// Code !! //
	//
	// Team  1 = blanc
	//		 2 = noir
	//
	//Char  1 = Bazooka
	//		2 = Grenade
	//
	//

	void Awake() 
	{
		SavedChar = PlayerPrefs.GetInt ("SelectedCharacter");
		SavedSpawn = PlayerPrefs.GetInt ("SelectedSpawn");	
		SavedTeam = PlayerPrefs.GetInt ("SelectedTeam");


		if (SavedTeam == 1) 
		{
			if (SavedChar <= 1) 
			{
				Rigidbody instantiatedChar = Instantiate (WhiteBa, new Vector3(755, 19, 557), new Quaternion(0,0,0,0)) as Rigidbody;
			}

			if (SavedChar == 2) 
			{
				Rigidbody instantiatedChar = Instantiate (WhiteGr, new Vector3(755, 19, 557), new Quaternion(0,0,0,0)) as Rigidbody;
			}

		}

		if (SavedTeam == 2) 
		{
			if (SavedChar == 1) 
			{
				Rigidbody instantiatedChar = Instantiate (BlackBa, new Vector3(755, 19, 557), new Quaternion(0,0,0,0)) as Rigidbody;
			}

			if (SavedChar == 2) 
			{
				Rigidbody instantiatedChar = Instantiate (BlackGr, new Vector3(755, 19, 557), new Quaternion(0,0,0,0)) as Rigidbody;
			}

		}

	}















	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
