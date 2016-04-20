using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_Health : MonoBehaviour {

	public int startingHealth = 100;                            
	public int currentHealth;                                   
	public Slider HealthSlider;                                 
	public Image damageImage;                                   
	public float flashSpeed = 5f;                               
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);  
	private Transform respawnPosition;
	public GameObject DeathCanvas;
	public GameObject WinCanvas;
	public GameObject Player;

	public bool isDead = false;                                                
	bool damaged = false; 

	
	void Awake ()
	{
		currentHealth = startingHealth;
		Time.timeScale = 1;
	}
	void Update ()
	{
		if(damaged)
		{
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}

		damaged = false;
	}

	void OnCollisionEnter(Collision col)
	{
		switch (col.gameObject.name) {
		case "Missile(Clone)":
			currentHealth -= 10;
			DeathUpdate ();
			break;
		case "Mob Bullet(Clone)":
			currentHealth -= 5;
			DeathUpdate ();
			break;
		case "Bomb":
			currentHealth -= 20;
			DeathUpdate ();
			break;
			
		}

		switch (col.gameObject.tag) {
		case "Mobster":
			currentHealth -= 5;
			DeathUpdate ();
			break;
		case "Win":
			Player.SetActive (false);
			WinCanvas.SetActive (true);
			break;
		case "Health":
			currentHealth = currentHealth + 10;
			HealthSlider.value = currentHealth;
			break;
			
		}
	}
	void DeathUpdate (){
		
		damaged = true;
		
		
		HealthSlider.value = currentHealth;
		
		if (currentHealth <= 0 && !isDead) {
			Player.SetActive (false);
			DeathCanvas.SetActive (true);
			Time.timeScale = 0;	
		}
	}


	void Death ()
	{
		isDead = true;
	}
}
