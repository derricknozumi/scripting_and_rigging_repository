using UnityEngine;
using System.Collections;

public class LieutenantAI3 :LieutenantAI {
	
	public override void OnCollisionEnter(Collision col)
	{
		switch (col.gameObject.name) {
		case "Gunshot(Clone)":
			HealthUpdate ();
			break;
		case "Laser(Clone)":
			HealthUpdate ();
			break;
		case "rocket(Clone)":
			HealthUpdate ();
			break;
			
		}
	}
	
	void HealthUpdate (){
		
		currentHealth -= 1;
		
		if (currentHealth <= 3) {
			transform.position = new Vector3(108f, 2.3f, 0f);
			transform.rotation = Quaternion.identity;
			rotate = false;
		}
		if (currentHealth <= 0 && !isDead) {
			Destroy (gameObject);
		}
	}
}
