using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {


	public UnityEngine.UI.Text montext = null;

	void Update ()
	{
		montext.text = PlayerManager.Instance.GetHealth(0).ToString();
	}

	void Awake()
	{
		PlayerManager.Instance.Vide();
	}

}
