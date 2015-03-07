using UnityEngine;
using System.Collections;

	public class PlayersManager
	{
		private PlayerData[] _players = new PlayerData[2];
		
		private static PlayersManager _instance = new PlayersManager();
		public static PlayersManager Instance
		{
			get
			{
				if(_instance == null)
					_instance = new PlayersManager();
				
				return _instance;
			}
		}

	
	public PlayersManager() 
	{
	}
	
	public bool IsAPlayerDead()
		{
			for (int i = 0; i < _players.Length; i++)
			{
				if (_players[i].Health <= 0)
				{
					return true;
				}
			}
			return false;
		}
		
		public void AddHealth(int playerId, int healthValue)
		{
			_players[playerId].Health += healthValue;
		}
		
		public int GetHealthValue(int playerId)
		{
			return _players[playerId].Health;
		}
		
		public void AddAmmo(int playerId, int ammoCountToAdd)
		{
			_players[playerId].AmmoCount += ammoCountToAdd;
		}
		
		public int GetAmmoCount(int playerId)
		{
			return _players[playerId].AmmoCount;
		}

	public class PlayerData
	{
		public int AmmoCount = 0;
		public int Health = 0;
	}
	
	public void SetAmmo(int playerId, int ammo)
	{
		_players [playerId].AmmoCount = ammo;
	}
	
	public void SetHealth(int playerId, int healthValue)
	{
		_players[playerId].Health = healthValue;
	}
}
	
	



