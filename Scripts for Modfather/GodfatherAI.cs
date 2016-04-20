using UnityEngine;
using System.Collections;

public class GodfatherAI : MonoBehaviour {

	
	
	public Transform player;
	public float move = 3f;
	public Rigidbody projectile;
	public float speed = 20;
	private Transform respawnPosition;
	static public bool rotate;
	public Transform target;
	public float bulletLife = 2.0f;
	public int startingHealth = 40;                            
	public int currentHealth;   
	bool isDead = false;                                                
	//bool isdamaged = false;                                              
	
	void Awake ()
	{
		currentHealth = startingHealth;
	}
	
	void Update(){
		
		transform.LookAt (player.position);
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Gunshot(Clone)") {

			
			currentHealth -= 1;
		
			if (currentHealth <= 0 && !isDead) {
				Destroy (gameObject);
			}
		}
		if (col.gameObject.name == "Laser(Clone)") {

			
			currentHealth -= 4;

		}
		if (currentHealth <= 0 && !isDead) {
			Destroy (gameObject);
		}
		if (col.gameObject.name == "rocket(Clone)") {

			
			currentHealth -= 2;

			if (currentHealth <= 0 && !isDead) {
				Destroy (gameObject);
			}
		}
	}

	void Death ()
	{
		isDead = true;
	}
	
}
