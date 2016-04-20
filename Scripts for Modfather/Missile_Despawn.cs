using UnityEngine;
using System.Collections;

public class Missile_Despawn : MonoBehaviour {

	public float bulletLife = 3.0f;
	
	void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.tag == "Player")
			Destroy(gameObject);
		
		else if (col.gameObject.tag == "wall")
			Destroy (gameObject);
		else 
			Destroy (this.gameObject, bulletLife);	
		
	}
}
