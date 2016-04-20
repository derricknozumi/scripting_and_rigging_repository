using UnityEngine;
using System.Collections;

public class Scroll_controller : MonoBehaviour {

	public float scrollSpeed;
	private Vector2 startingOffset;
	private Vector2 savedOffset;
	public float tileSizeX;
	public GameObject Player;
	public float numbers;


	void Start () {
		startingOffset = GetComponent<Renderer> ().sharedMaterial.GetTextureOffset ("_MainTex");
		savedOffset = GetComponent<Renderer> ().sharedMaterial.GetTextureOffset ("_MainTex");
		//GetComponentInChildren;
	}

	void Update () {
		numbers = Player.GetComponent<Rigidbody> ().transform.position.x;
		float x = Mathf.Repeat (numbers * scrollSpeed, 1);
		Vector2 offset = new Vector2 (x, savedOffset.y);
		GetComponent<Renderer> ().sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}