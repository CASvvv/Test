using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potato : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDrag() {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 1.0f;
		this.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
	}
}
