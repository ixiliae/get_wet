using UnityEngine;
using System.Collections;

public class Ammo2Bar : MonoBehaviour {
	
	public UnityEngine.UI.Text montext = null;
	
	void Update () {
		montext.text = PlayerManager.Instance.GetAmmo2(0).ToString();
	}
}
