using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherController : MonoBehaviour, IDamagable {

	enum State{
		IDLE, MOVING, ATTACKING
	}

	public int maxHealth = 80;
	public int currentHealth;

	private State currentState = State.IDLE;
	private ArcherMovement movementScript;

	// Use this for initialization
	void Start () {
		movementScript = GetComponent<ArcherMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
			case State.ATTACKING:
				HandleAttacking ();
				break;
			case State.MOVING:
				HandleMoving ();
				break;
			default:
				HandleIdle ();
				break;
		}
	}

	public void Damage(int amount){
		currentHealth -= amount;
		if (currentHealth <= 0) {
			Destroy (gameObject);
		}
	}

	void HandleIdle(){
		movementScript.LookAtPlayer ();
	}

	void HandleMoving(){

	}

	void HandleAttacking(){

	}
}
