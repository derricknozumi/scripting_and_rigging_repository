using UnityEngine;
using System.Collections;

public class Player_follow_cam : MonoBehaviour {

	
	public GameObject player;

	void Start()
	{
		
	}

	void LateUpdate()
	{

		transform.position = player.transform.position + new Vector3 (5, 1.5f, -15);
	}	
}

