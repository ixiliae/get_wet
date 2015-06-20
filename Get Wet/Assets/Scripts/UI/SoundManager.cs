using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public SoundManager MyMusic = null;

	public AudioClip backMusic;

	public Slider mainSlider;
	public float Volume;

	public virtual void OnEnter()
	{

	}
	
	public virtual void OnUpdate()
	{

	}

	public virtual void OnExit()
	{
		
	}

	public void ChangeVolume(float Volume)
	{
		AudioListener.volume = Volume;
		Debug.Log (Volume);
	}

}
