using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bane : MonoBehaviour {

	[SerializeField]
	private float power;

	// Use this for initialization
	void Start () {
		//this.transform.rotation = Quaternion.Euler(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col) {
		col.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, power));
		col.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		col.gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
	}
}
