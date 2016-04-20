using UnityEngine;
using System.Collections;

public class TommyGun : MonoBehaviour {

	public Rigidbody projectile; 
	public Transform target; 
	public float speed = 20;
	public float bulletLife = 2.0f;
	
	public float duration;
	private float elapsed;

	void FixedUpdate () {
		elapsed += Time.deltaTime;
		if (elapsed >= duration) {
			EnemyAI ();
			elapsed = 0;
		} 
	}

	void EnemyAI () {
		if (Vector3.Distance (transform.position, target.position) < 15f) {
			Rigidbody instantiatedProjectile = Instantiate (projectile,
			                                                transform.position,
			                                                transform.rotation)
				as Rigidbody;
			
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));

		}
	}
}
