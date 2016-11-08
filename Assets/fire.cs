using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {

public Rigidbody projectile;
public Transform Spawnpoint;
public int shootSpeed;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){//fire1 is left mouse button
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);
			clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);
		}
	}
}
