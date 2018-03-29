using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sling : MonoBehaviour
{
	[SerializeField] private Transform anchor;
	private Ball ball;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			AttachBall(collision.gameObject);
		}
	}

	public void AttachBall(GameObject ballObject)
	{
		ball = ballObject.GetComponent<Ball>();
		ball.Stop();
		ball.transform.position = anchor.position;
	}

	public void ThrowBall()
	{
		if (ball != null)
		{
			ball.ThrowBall(transform.up * 500f);
			ball = null;
		}
	}
}
