using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
