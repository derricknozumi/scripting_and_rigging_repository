using UnityEngine;
using System.Collections;
using System;

public class Player_gun : MonoBehaviour {
	public Rigidbody projectile;
	public Rigidbody rocketshot;
	public Rigidbody lasershot;
	public float firingSpeed = 20;
	static public bool gun = true;
	static public bool rocket = false;
	static public bool laser = false;
	public GameObject bullet;
	public delegate void collectScrap ();
	public static event collectScrap onContact;
	
	
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Scrap")
		{
			onContact();
			gunUpgrade();

		}
	}
	void gunUpgrade (){
		switch (ScrapCounter.scrap) {
		case 0:
			print ("case 0");
			laser = false;
			rocket = false;
			gun = true;
			break;
			
		case 3:
			print ("case 3");
			gun = false;
			rocket = true;
			break;
			
		case 6:
			print ("case 6");
			gun = false;
			rocket = false;
			laser = true;
			break;
			
		default:
			
			
			break;
		}
	}
	
	void Update ()
	{
		
		if (Input.GetKeyUp (KeyCode.C)) {
			if (gun == true) {
				Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
				
				instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, firingSpeed));
				
			}
			
			if (rocket == true) {
				Rigidbody instantiatedrocketshot = Instantiate (rocketshot, transform.position, transform.rotation) as Rigidbody;
				
				instantiatedrocketshot.velocity = transform.TransformDirection (new Vector3 (0, 0, firingSpeed));
				
			}
			if (laser == true) {
				Rigidbody instantiatedlasershot = Instantiate (lasershot, transform.position, transform.rotation) as Rigidbody;
				
				instantiatedlasershot.velocity = transform.TransformDirection (new Vector3 (0, 0, firingSpeed));
				
			}
		}
		
	}
}

