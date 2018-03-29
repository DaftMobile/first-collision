using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
	private Rigidbody2D rigidbody2d;

	private void Awake()
	{
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	public void ThrowShuriken(Vector2 throwForce)
	{
		rigidbody2d.AddForce(throwForce);
		rigidbody2d.AddTorque(10);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			Destroy(collision.gameObject);
			Destroy(gameObject);
		}

		if (collision.gameObject.tag == "ShurikenLauncher")
		{
			Destroy(gameObject);
		}
	}
}
