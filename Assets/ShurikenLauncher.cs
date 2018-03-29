using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenLauncher : MonoBehaviour
{
	[SerializeField] private GameObject shurikenPrefab;

	private void Start()
	{
		Invoke("ThrowShuriken", Random.Range(0, 2));
	}

	public void ThrowShuriken()
	{
		GameObject shuriken = Instantiate(shurikenPrefab);
		shuriken.transform.position = new Vector3(transform.position.x, Random.Range(-1.5f, 1.5f), 0f);
		shuriken.GetComponent<Shuriken>().ThrowShuriken(transform.right * 300f);

		Invoke("ThrowShuriken", Random.Range(2, 5));
	}
}
