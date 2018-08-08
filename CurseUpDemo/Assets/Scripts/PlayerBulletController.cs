using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour {

    public float damage = 5f;
    public float speed = 2f;

    private new Rigidbody2D rigidbody;
    private LayerMask blockingLayer;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        blockingLayer = LayerMask.NameToLayer("Blocking");
    }

    // Use this for initialization
    void Start ()
    {
        //rigidbody.AddForce(targetVelocity * speed);
        rigidbody.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Bullet found enemy");
            collision.SendMessageUpwards("Damage", damage);
        }

        if (collision.GetComponent<Collider2D>().gameObject.layer == blockingLayer)
        {
            Destroy(gameObject);
        }
    }
}
