using UnityEngine;
using System.Collections;

public class changemusic : MonoBehaviour {

	public AudioClip Background_Music;

	private AudioSource source;

	void Awake ()
	{
		source = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded (int level)
	{
		if (level == 0)
		{
			source.clip = Background_Music;
			source.Play ();
		}
	}
}