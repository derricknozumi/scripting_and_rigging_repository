using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrapCounter : MonoBehaviour {

	public static int scrap;

	Text text;

	void Awake ()
	{
		text = GetComponent <Text> ();

		scrap = 0;
	}

	void Update ()
	{
		text.text = "Scrap: " + scrap;
	}
}