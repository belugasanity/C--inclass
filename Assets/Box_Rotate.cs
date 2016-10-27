using UnityEngine;
using System.Collections;

public class Box_Rotate : MonoBehaviour {

	public float rotateSpeed;

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
