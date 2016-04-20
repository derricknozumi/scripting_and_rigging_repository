using UnityEngine;
using System.Collections;

public class CharBulletDespawn : MonoBehaviour {

	public float bulletLife = .5f;

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag == "Mobster")
			Destroy (gameObject);

		else if (col.gameObject.tag == "Mobster Lieutenant")
			Destroy (gameObject);

		else if (col.gameObject.tag == "Godfather")
			Destroy (gameObject);

		else if (col.gameObject.tag == "wall")
			Destroy (gameObject);

		else if (col.gameObject.tag == "ground")
			Destroy (gameObject);

		else if (col.gameObject.tag == "enembullet")
			Destroy (gameObject);

		else if (col.gameObject.tag == "Health")
			Destroy (gameObject);
		
		else if (col.gameObject.tag == "Scrap")
			Destroy (gameObject);


		else 
			Destroy (this.gameObject, bulletLife);

	}
}
