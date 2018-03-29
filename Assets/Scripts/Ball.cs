using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	private Rigidbody2D rigidbody2d;

	private void Awake()
	{
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	public void ThrowBall(Vector2 throwForce)
	{
		rigidbody2d.AddForce(throwForce);
	}

	public void Stop()
	{
		rigidbody2d.velocity = Vector2.zero;
	}
}
