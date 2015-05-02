using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoBar : MonoBehaviour {

	public int PlayerId = -1;
	public Image FullImage;
	private float PreviousValue = 0.0f;

	public UnityEngine.UI.Text montext = null;

	void Update () 
	{
		montext.text = PlayerManager.Instance.GetAmmo(0).ToString();

		if(PlayerId != -1)
		{
			float ratio = PlayerManager.Instance.GetAmmoLeftRatio(PlayerId);
			if (ratio != PreviousValue)
			{
				FullImage.fillAmount = ratio;
			}
		}
	}
}
