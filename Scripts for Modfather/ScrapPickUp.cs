using UnityEngine;
using System.Collections;
using System;
public class ScrapPickUp : MonoBehaviour {
	
	public GameObject[] allScrap;
	public int ScrapNumber = 1;
	public int scrapArray;
	
	void OnEnable ()
	{
		
		Player_gun.onContact += Scrap;
		
	}
	void OnDisable ()
	{
		Player_gun.onContact -= Scrap;
	}
	
	void Scrap ()
	{
		allScrap [scrapArray].gameObject.SetActive(false);
		scrapArray ++;
		ScrapCounter.scrap += ScrapNumber;
	}
}
