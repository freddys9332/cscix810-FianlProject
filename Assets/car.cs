using UnityEngine;
using System.Collections;

public class car : MonoBehaviour
{

	public float moveSpeed = 15f;
	public float turnSpeed = 540f;

	// Update is called once per frame
	void Update()
	{

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		//transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

		//Move 
		transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

		//Turn
		transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);

	}
}