using UnityEngine;
public class coin : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			transform.GetComponent<Collider>().enabled = false;
			transform.GetComponent<Renderer>().enabled = false;
		}
	}
}
