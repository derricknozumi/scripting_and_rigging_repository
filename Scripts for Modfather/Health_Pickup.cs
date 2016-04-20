using UnityEngine;
using System.Collections;

public class Health_Pickup : MonoBehaviour {

		public int startingHealth = 1;            
		public int currentHealth;                               
		public int healthValue = 10;                 
		
		bool isDestroyed = false;                               

		
		
		void Awake ()
		{
			currentHealth = startingHealth;
		}
		
		void OnCollisionEnter(Collision col)
		{
			if (col.gameObject.name == "Player") {
				
				currentHealth -= 1;
				
				
				
				if (currentHealth <= 0 && !isDestroyed) {
					Destroy (gameObject);
				}
				if (currentHealth <= 0 &&!isDestroyed) {
			
				}
			}
		}
		
		void Death ()
		{
			isDestroyed = true;
			
		}
		
	}
