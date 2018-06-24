using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Done_MoverBolt : MonoBehaviour {

	public float speed;
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = transform.up * speed;
	}
}
