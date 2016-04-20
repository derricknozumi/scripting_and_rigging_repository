using UnityEngine;
using System.Collections;

public class Loadonclick : MonoBehaviour {

public void LoadScene (int level)
	{
		Application.LoadLevel (level);
	}
	}