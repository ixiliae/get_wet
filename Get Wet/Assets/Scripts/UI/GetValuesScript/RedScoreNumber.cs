using UnityEngine;
using System.Collections;

public class RedScoreNumber : MonoBehaviour {
	
	public UnityEngine.UI.Text montext = null;
	public int Score = 0;
	
	//void Start(){
	//	PlayerPrefs.SetInt ("MyRedScore", (Score));
	//}
	
	void Update () {
		montext.text = PlayerPrefs.GetInt("MyRedScore").ToString();
	}
}
