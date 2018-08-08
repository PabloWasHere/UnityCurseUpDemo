using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletAttack : MonoBehaviour {

    public GameObject bullet;
    public Transform spawnLocation;
    public float attackCooldown = 0.3f;
    public Animator animator;

    private bool attacking = false;
    private float attackTimer = 0;

    void Awake()
    {
        //animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
            }
        }
    }

    public void Attack()
    {
        if (!attacking)
        {
            Debug.Log("Player attacking");

            attacking = true;
            attackTimer = attackCooldown;

			if (animator != null) {
				animator.SetTrigger ("Shooting");
			}

            Instantiate(bullet, spawnLocation.position, spawnLocation.rotation);
        }
    }
}
