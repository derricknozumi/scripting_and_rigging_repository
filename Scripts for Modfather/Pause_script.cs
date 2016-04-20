using UnityEngine;
using System.Collections;

public class Pause_script : MonoBehaviour {

	public GameObject Pausemenu;
	public bool paused;

	void Start () {
		paused = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void Pause (){

			paused = !paused;

		if (paused) {
			Time.timeScale = 0;
			Pausemenu.SetActive (true);

		} 
		else if (!paused){
			Time.timeScale = 1;
			Pausemenu.SetActive (false);
		}
	}

}
