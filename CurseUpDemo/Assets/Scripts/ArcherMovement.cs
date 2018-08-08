using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherMovement : MonoBehaviour {

	private Transform player;
	private Transform transform;
	private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player").transform;
		rigidbody = GetComponent<Rigidbody2D>();
		transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LookAtPlayer(){
		float angleRad = Mathf.Atan2(player.position.y - transform.position.y, player.position.x - transform.position.x);
		float angle = (180 / Mathf.PI) * angleRad;

		rigidbody.rotation = angle;
	}
}
