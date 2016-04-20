using UnityEngine;
using System.Collections;

public class BulletDespawn : MonoBehaviour {

	public float bulletLife = 1.0f;

	void OnCollisionEnter(Collision col)
	{
	
		if (col.gameObject.tag == "Player")
			Destroy(gameObject);
		
		else if (col.gameObject.tag == "wall")
			Destroy (gameObject);

		else if (col.gameObject.tag == "charbullet")
			Destroy (gameObject);

		else if (col.gameObject.tag == "Health")
			Destroy (gameObject);

		else if (col.gameObject.tag == "Scrap")
			Destroy (gameObject);

		else if (col.gameObject.tag == "ground")
			Destroy (gameObject);

		else 
			Destroy (this.gameObject, bulletLife);
		
		
	}
}
