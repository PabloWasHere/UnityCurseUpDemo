using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IDamagable{

    public PlayerSwordAttack swordScript;
    public PlayerBulletAttack bulletScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            bulletScript.Attack();
        }

        if (Input.GetMouseButtonDown(0))
        {
            swordScript.Attack();
        }
    }

	public void Damage(int amount){
		
	}
}
