using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	[SerializeField] private GameObject prefab;
	[SerializeField] private Sling[] sling;

	private void Start()
	{
		GameObject ball = Instantiate(prefab);
		sling[0].AttachBall(ball);
	}

	public void Update()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			for (int i = 0; i < sling.Length; i++)
			{
				sling[i].ThrowBall();
			}
		}
	}
}
