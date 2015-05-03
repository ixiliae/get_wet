using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KillBar : MonoBehaviour {

	public int PlayerId = -1;

	public UnityEngine.UI.Text montext = null;
	
	void Start () {

	}

	void Update () {
		montext.text = PlayerManager.Instance.GetKills(PlayerId).ToString();
	}
}
