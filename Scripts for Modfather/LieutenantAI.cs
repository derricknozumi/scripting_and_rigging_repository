using UnityEngine;
using System.Collections;

public class LieutenantAI : MonoBehaviour {

	
	public Transform player;
	public float move = 3f;
	public Rigidbody projectile;
	public float speed = 20;
	private Transform respawnPosition;
	static public bool rotate;
	public Transform target;
	public float bulletLife = 2.0f;
	public int startingHealth = 24;                            
	public int currentHealth;   
	public bool isDead = false;                                                
                                          


	public void Awake ()
	{
		currentHealth = startingHealth;
	}

	public void Update(){
		
		transform.LookAt (player.position);
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);

	}
	public virtual void OnCollisionEnter(Collision col)
	{
		switch (col.gameObject.name) {
		case "Gunshot(Clone)":
			currentHealth -= 1;
			HealthUpdate ();
			break;
		case "Laser(Clone)":
			currentHealth -= 4;
			HealthUpdate ();
			break;
		case "rocket(Clone)":
			currentHealth -= 2;
			HealthUpdate ();
			break;
			
		}
	}

	public void HealthUpdate (){
		
	
		
		if (currentHealth == 12) {
			transform.position = new Vector3 (85.8f, 2.3f, 0f);
			transform.rotation = Quaternion.identity;
			rotate = false;
		}
		if (currentHealth <= 0 && !isDead) {
			Destroy (gameObject);
		}
	}


	public void Death ()
	{
		isDead = true;
	}

}
