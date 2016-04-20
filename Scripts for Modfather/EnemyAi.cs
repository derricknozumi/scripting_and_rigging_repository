using UnityEngine;
using System.Collections;

public class EnemyAi: MonoBehaviour {

	public Transform player;
	public float move = 3f;
	public Rigidbody projectile;
	public float speed = 20;
	protected Transform respawnPosition;
	static public bool rotate;
	public int startingHealth = 6;                            
	public int currentHealth;   
	protected bool isDead = false;  
	public Animator anim;

	public void Awake ()
	{
		currentHealth = startingHealth;
		anim = this.GetComponent<Animator> ();
	}
	
	public void Update(){

		transform.LookAt (player.position);
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);
		


		if (Vector3.Distance (transform.position, player.position) < 10f) {
			transform.Translate (new Vector3 (move * Time.deltaTime, 0, 0));
			anim.SetInteger ("speed", 2);
		} else
			anim.SetInteger ("speed", 0);		
		
	}
	
	
	
	public virtual void OnCollisionEnter(Collision col)
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
	
	public void HealthUpdate (){
		
		currentHealth -= 1;
		
		if (currentHealth <= 3) {
			transform.position = new Vector3 (43.6f, 1f, 0f);
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