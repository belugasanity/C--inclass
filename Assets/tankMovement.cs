using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tankMovement : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	public Text countText;
	private Rigidbody rb;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

}
	//void OnTriggerEnter (Collider Coin){
	//	if (Coin.gameObject.CompareTag ("Pick Up")) {
	//		Coin.gameObject.SetActive (false);
	//	}
	//}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag ("Pick Up")){
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText ();
		}
	}
	void SetCountText (){
		countText.text = "Count: " + count.ToString ();
	}
}