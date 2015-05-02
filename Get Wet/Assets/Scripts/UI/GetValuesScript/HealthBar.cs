using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public int PlayerId = -1;
	public Image FullImage;
	private float PreviousValue = 0.0f;
	
	public UnityEngine.UI.Text montext = null;

	void Update ()
	{
		montext.text = PlayerManager.Instance.GetHealth(0).ToString();

		if(PlayerId != -1)
		{
			float ratio = PlayerManager.Instance.GetHealthLeftRatio(PlayerId);
			if (ratio != PreviousValue)
			{
				FullImage.fillAmount = ratio;
			}
		}
	}

	void Awake()
	{
		PlayerManager.Instance.Vide();
	}

}



//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//
//public class HealthBar : MonoBehaviour
//{
//	public int m_PlayerId = -1;
//	public Image m_FullImage;
//	private float m_PreviousValue = 0.0f;
//	
//	// Use this for initialization
//	void Start ()
//	{
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if(m_PlayerId != -1)
//		{
//			float ratio = PlayerManager.Instance.GetHealthLeftRatio (m_PlayerId);
//			if (ratio != m_PreviousValue)
//			{
//				m_FullImage.fillAmount = ratio;
//			}
//		}
//	}
//}
//