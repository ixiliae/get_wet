using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{	
			private PlayerData[] _players = new PlayerData[32];
			
			private static PlayerManager _instance = new PlayerManager();
			public static PlayerManager Instance
			{
				get
				{
					if (_instance == null)
					{
						GameObject go = new GameObject("PlayerManager");
						_instance = go.AddComponent<PlayerManager>();
					}
					
					return _instance;
				}
			}

		
			public void SetValues()
			{
				for (int i = 0; i < 32; i++) 
				{
					_players[i].ammo = 100;
					_players[i].health = 100;
					_players[i].score = 0;
					_players[i].kills = 0;
					_players[i].deaths = 0;
					_players[i].objectives = 0;
					_players[i].spawn = 0;
					_players[i].character = 0;
				}
			}
			
			public void Revive(int ID)
			{
				_players[ID].ammo = 100;
				_players[ID].health = 100;
			}
	
			public PlayerManager() 
			{
			
			}
			
			public bool IsAPlayerDead()
			{
				for (int i = 0; i < _players.Length; i++)
				{
					if (_players[i].health <= 0)
					{
						return true;
					}
				}
				return false;
			}

	// // // // // // // //	// // // //	// // // // // //	

			public void AddHealth(int ID, int healthValue)
			{
				_players[ID].health += healthValue;
			}
			
			public int GetHealth(int ID)
			{
				return _players[ID].health;
			}                                                  
		
	// // // // // // // //	// // // //	// // // // // //	

			public void AddAmmo(int ID, int ammoCountToAdd)
			{
				_players[ID].ammo += ammoCountToAdd;       
			}
			
			public int GetAmmo(int ID)                       
			{
				return _players[ID].ammo;                         
			}

	// // // // // // // //	// // // //	// // // // // //	

			public void AddScore(int ID, int Score)
			{
				_players[ID].ammo += Score;
			}
						
			public int GetScore(int ID)
			{
				return _players[ID].score;
			}

	// // // // // // // //	// // // //	// // // // // //	

			public void AddKills(int ID, int Kills)
			{
				_players[ID].kills += Kills;
			}
			
			public int GetKills(int ID)
			{
				return _players[ID].kills;
			}
		
	// // // // // // // //	// // // //	// // // // // //	

			public void AddDeaths(int ID, int Deaths)
			{
				_players[ID].deaths += Deaths;
			}
			
			public int GetDeaths(int ID)
			{
				return _players[ID].deaths;
			}

	// // // // // // // //	// // // //	// // // // // //	

			public void AddObjectives(int ID, int Objectives)
			{
				_players[ID].objectives += Objectives;
			}
			
			public int GetObjectives(int ID)
			{
				return _players[ID].objectives;
			}

	// // // // // // // //	// // // //	// // // // // //	
			
			public void SetAmmo(int ID, int ammo)
			{
				_players [ID].ammo = ammo;
			}
			
			public void SetHealth(int ID, int healthValue)
			{
				_players[ID].ammo = healthValue;
			}

			public void Vide()
			{
				
			}

			





//	        public void Health(int ID)
//	        {
//				PlayerManager.Instance.GetHealth(ID);
//				
//	        }
//
//			public void Ammo(int ID)
//			{
//				PlayerManager.Instance.GetAmmo(ID);
//			}
//
//			public void Scores(int ID)
//			{
//				PlayerManager.Instance.GetScore(ID);
//			}
	
	
	
	
	
	    // PlayerManager.Instance.AddHealth(0, -30); // retire 30 de vie au perso 0
		// PlayerManager.Instance.AddAmmo(0, -30);
		// if(PlayerManager.Instance.IsAPlayerDead()) // si un des persos est mort
		// {
		// 	
		// }
	}
	
	



