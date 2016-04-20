using UnityEngine;
using System.Collections;

public class Bomb_script : MonoBehaviour { 
// Contains Coroutine

	public Animator anim;
	
	void Awake ()
	{
		anim = this.GetComponent<Animator> ();
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			anim.SetBool ("explosion", true);
			StartCoroutine (explosion());
		} 
		else 
		{
			anim.SetBool ("explosion", false);
	
		}		
	}
	IEnumerator explosion() {
		Renderer [] rs = GetComponentsInChildren <MeshRenderer>();
		foreach (Renderer r in rs) {
			r.enabled = false;
		}
		yield return new WaitForSeconds (1f);
		Destroy (gameObject);			
			
		}
	}
