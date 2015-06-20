using UnityEngine;
using System.Collections;

public class BlueScoreNumber : MonoBehaviour {

	public UnityEngine.UI.Text montext = null;
	public int Score = 0;

	//void Start(){
	//	PlayerPrefs.SetInt ("MyBlueScore", (Score));
	//}
	
	void Update () {
		montext.text = PlayerPrefs.GetInt("MyBlueScore").ToString();
	}
}
