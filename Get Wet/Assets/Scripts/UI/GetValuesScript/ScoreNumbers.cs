using UnityEngine;
using System.Collections;

public class ScoreNumbers : MonoBehaviour {

	public UnityEngine.UI.Text montext = null;
	
	void Update () {
		montext.text = PlayerManager.Instance.GetScore(0).ToString();
	}
}
