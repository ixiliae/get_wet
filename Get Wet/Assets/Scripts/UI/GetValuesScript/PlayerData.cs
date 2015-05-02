using UnityEngine;
using System.Collections;

public class PlayerData
{
	public PlayerData()
	{
		health = Maxhealth;
	}
	
	public int health = 0;
	public int Maxhealth = 100;
	
	public string name;
	public int ammo;
	public int ammo2;
	public int score;
	public int spawn;
	public int character;
	public int kills;
	public int deaths;
	public int objectives;	
}