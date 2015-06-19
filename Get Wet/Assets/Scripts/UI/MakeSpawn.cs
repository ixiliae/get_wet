using UnityEngine;
using System.Collections;

public class MakeSpawn : MonoBehaviour {



	public GameObject WhiteBa = GameObject.Find("whiteBazooka");
	public GameObject BlackBa = GameObject.Find("blackBazooka");
	public GameObject WhiteGr = GameObject.Find("whiteGrenade");
	public GameObject BlackGr = GameObject.Find("blackGrenade");
	public GameObject WhiteShot = GameObject.Find("whiteShotgun");
	public GameObject BlackShot = GameObject.Find("blackShotgun");
	public GameObject AmyCac = GameObject.Find("MagicAmyCac");
	public GameObject AmySniper = GameObject.Find ("MagicAmySniper");

//	public GameObject Character5 = GameObject.Find("whiteShotgun");
//	public GameObject Character6 = GameObject.Find("blackShotgun");
	

	public int SavedChar = 1;
	public int SavedSpawn = 0;
	public int SavedWeapon = 1;



	// Code !! //
	//
	// Char  1 = blanc
	//		 2 = noir
	//       3 = Amy
	//
	// Weapon 1 = Bazooka
	//		  2 = Grenade
	//		  3 = Shotgun
	//	 	 1 = Cac
	// 		 2 = Sniper


	void Awake() 
	{
		SavedChar = PlayerPrefs.GetInt ("SelectedCharacter");
		SavedSpawn = PlayerPrefs.GetInt ("SelectedSpawn");	
		SavedWeapon = PlayerPrefs.GetInt ("SelectedWeapon");

		if (SavedChar == 1) 
		{
			if (SavedWeapon <= 1) 
			{
				Rigidbody instantiatedChar = Instantiate(WhiteBa, new Vector3(867.3768f, 20.6454f, 980.1852f), new Quaternion(0, 0, 0, 0)) as Rigidbody;
			}
			
			if (SavedWeapon == 2) 
			{
				Rigidbody instantiatedChar = Instantiate(WhiteGr, new Vector3(378.6492f, 35.28006f, 544.9284f), new Quaternion(0, 0, 0, 0)) as Rigidbody;
			}
			
			if (SavedWeapon == 3) 
			{
				Rigidbody instantiatedChar = Instantiate(WhiteShot, new Vector3(378.6492f, 35.28006f, 544.9284f), new Quaternion(0, 0, 0, 0)) as Rigidbody;
			}
		}
		
		
		if (SavedChar == 2) 
		{
			if (SavedWeapon == 1) 
			{
				Rigidbody instantiatedChar = Instantiate(BlackBa, new Vector3(577.2406f, 20.8276f, 65.2534f), new Quaternion(0, 0, 0, 0)) as Rigidbody;
			}
			
			if (SavedWeapon == 2) 
			{
				Rigidbody instantiatedChar = Instantiate (BlackGr, new Vector3(755, 19, 557), new Quaternion(0,0,0,0)) as Rigidbody;
			}
			
			if (SavedWeapon == 3) 
			{
				Rigidbody instantiatedChar = Instantiate (BlackShot, new Vector3(755, 19, 557), new Quaternion(0,0,0,0)) as Rigidbody;
			}
		}
		
		if (SavedChar == 3) 
		{
			if (SavedWeapon <= 1) 
			{
				Rigidbody instantiatedChar = Instantiate (AmyCac, new Vector3 (867.3768f, 20.6454f, 980.1852f), new Quaternion (0, 0, 0, 0)) as Rigidbody;
			}
			
			if (SavedWeapon == 2) 
			{
				Rigidbody instantiatedChar = Instantiate (AmySniper, new Vector3 (378.6492f, 35.28006f, 544.9284f), new Quaternion (0, 0, 0, 0)) as Rigidbody;
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
