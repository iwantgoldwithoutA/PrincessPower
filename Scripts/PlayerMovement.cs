using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D rb;
	private Collider2D coll;
	private SpriteRenderer sp;

	[SerializeField] private LayerMask ground;
	[SerializeField] public float speed;
	[SerializeField] public float jumpForce;
	[SerializeField] public Sprite dieSprite;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		coll = GetComponent<Collider2D>();
		sp = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		Movement();
	}

	private void Movement()
	{
		float hDirection = Input.GetAxis("Horizontal");

		// Moving left
		if (hDirection < 0)
		{
			rb.velocity = new Vector2(-speed, rb.velocity.y);
			transform.localScale = new Vector2(-1, 1);
		}
		// Moving right
		else if (hDirection > 0)
		{
			rb.velocity = new Vector2(speed, rb.velocity.y);
			transform.localScale = new Vector2(1, 1);
		}

		// Jumping
		if (Input.GetButtonDown("Jump") && coll.IsTouchingLayers(ground))
		{
			Jump();
		}
	}

	private void Jump()
	{
		rb.velocity = new Vector2(rb.velocity.x, jumpForce);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Die();
		}
	}

	private void Die()
	{
		sp.sprite = dieSprite;
		rb.constraints = RigidbodyConstraints2D.FreezePositionX;
		
		rb.velocity = Vector2.zero;
		coll.enabled = false; Jump();
	}
}
