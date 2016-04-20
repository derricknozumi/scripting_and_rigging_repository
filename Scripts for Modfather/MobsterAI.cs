using UnityEngine;
using System.Collections;

public class MobsterAI : MonoBehaviour {

	
	public Transform player;
	public float move = 3f;
	public Rigidbody projectile;
	public float speed = 20;
	private Transform respawnPosition;
	static public bool rotate;
	public int startingHealth = 6;                            
	public int currentHealth;   
	bool isDead = false;  
	//bool isdamaged =false;
	public Animator anim;
	
	void Awake ()
	{
		currentHealth = startingHealth;
		anim = this.GetComponent<Animator> ();
	}
	
	void Update(){
		
		transform.LookAt (player.position);
		
		//transform.LookAt = new Vector3 (player.position.x, 0f , 0f );
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);
		
		
		
		if (Vector3.Distance (transform.position, player.position) < 10f) {
			//	transform.LookAt = new Vector3 (player.position.x,0,0);
			transform.Translate (new Vector3 (move * Time.deltaTime, 0, 0));
			anim.SetInteger ("speed", 2);
		} else
			anim.SetInteger ("speed", 0);		
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Gunshot(Clone)") {
			//isdamaged = true;
			
			currentHealth -= 1;
			
			if (currentHealth <= 3) {
				transform.position = new Vector3(100f, 2.5f, 0f);
				transform.rotation = Quaternion.identity;
				rotate = false;
			}
			if (currentHealth <= 0 && !isDead) {
				Destroy (gameObject);
			}
			
		}
		if (col.gameObject.name == "Laser(Clone)") {
			//isdamaged = true;
			
			currentHealth -= 3;
			
			if (currentHealth <= 3) {
				transform.position = new Vector3 (100f, 2.5f, 0f);
				transform.rotation = Quaternion.identity;
				rotate = false;
			}
		}
		if (currentHealth <= 0 && !isDead) {
			Destroy (gameObject);
		}
		if (col.gameObject.name == "rocket(Clone)") {
			//isdamaged = true;
			
			currentHealth -= 2;
			
			if (currentHealth <= 3) {
				transform.position = new Vector3 (100f, 2.5f, 0f);
				transform.rotation = Quaternion.identity;
				rotate = false;
			}
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