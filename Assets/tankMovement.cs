using UnityEngine;
using System.Collections;

public class tankMovement : MonoBehaviour {
	private int score = 0;

	public float moveSpeed;
	public float turnSpeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}
