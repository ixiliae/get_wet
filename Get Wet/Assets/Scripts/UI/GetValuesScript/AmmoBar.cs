using UnityEngine;
using System.Collections;

public class AmmoBar : MonoBehaviour {

	public UnityEngine.UI.Text montext = null;

	void Update () {
		montext.text = PlayerManager.Instance.GetAmmo(0).ToString();
	}
}
