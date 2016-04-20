using UnityEngine;
using System.Collections;

public class Moveshootplayer : MonoBehaviour {
	

	public float speed = 10.0f;
	public float jumpSpeed = 7.0f;
	public float jumpCount = 1;
	static public bool rotate;
	public float maxJump = 2;
	public float turnSpeed = 100;
	bool onGrounded = true;
	private Transform respawnPosition;
	public float currentscrap;
	public GameObject WinCanvas;
	public float moveVelocity;
	public Animator anim;

	void Awake ()
	{
		anim = this.GetComponent<Animator> ();
	}
	void Update () {
//movement script
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
	
			if(Input.GetKeyDown (KeyCode.RightArrow)) {
			GetComponent<Rigidbody>(). velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody>().velocity.x);
		}
			if (Input.GetAxisRaw ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) {
			transform.forward = new Vector3 (0, 0, Input.GetAxis ("Horizontal"));
		anim.SetInteger ("speed", 2);
		} 
		else
		{
			anim.SetInteger ("speed", 0);	
		}
		if (Input.GetKeyDown (KeyCode.Space) && maxJump < 2) 
			
			GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
		
		
		if (Input.GetKeyDown (KeyCode.Space) && jumpCount < maxJump) {
			GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
			jumpCount ++;
		}

		if (jumpCount > maxJump || onGrounded == false) {
			jumpSpeed = 0.0f;
			
		} 
		if (jumpCount > maxJump && onGrounded == true) {
			jumpSpeed = 0.0f;
			jumpCount = 0;
			
		}
	
	}

		void OnCollisionEnter(Collision col)
		{
			
		if (col.gameObject.tag == "ground") {
			jumpCount = 1;
			jumpSpeed = 7;
		}
	}

}