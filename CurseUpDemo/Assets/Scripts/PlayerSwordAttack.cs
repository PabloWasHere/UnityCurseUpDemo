using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordAttack : MonoBehaviour {

    public Collider2D attackTrigger;
    public Animator animator;

    private bool attacking = false;
    private float attackTimer = 0;
    private float attackCd = 0.3f;
    
    void Awake(){
        attackTrigger.enabled = false;
        //animator = GetComponentsInChildren<Animator>()[0];
    }

    void Update(){
        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
    }

    public void Attack()
    {
        if (!attacking)
        {
            //Debug.Log("Player attacking");

            attacking = true;
            attackTimer = attackCd;

			if (animator != null) {
				animator.SetTrigger ("Attacking");
			}

            attackTrigger.enabled = true;
        }
    }
}
