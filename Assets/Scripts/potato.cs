using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potato : MonoBehaviour {

	private float move;

	// Use this for initialization
	void Start () {
		move = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (-1 * move * Time.deltaTime, 0, 0);
	}

	void OnMouseDrag() {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 1.0f;
		this.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
	}
}
