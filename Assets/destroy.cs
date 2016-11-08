using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public float countDown;
	public GameObject explosion;
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name == "Terrain"){
			Instantiate(explosion,transform.position,transform.rotation);
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		Destroy (gameObject, countDown);
	}
}
