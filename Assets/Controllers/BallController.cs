using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Finish")) {
			Vector3 upForce = new Vector3 (0, 7500, 0);
			rb.AddForce (upForce);
		}
	}
}
