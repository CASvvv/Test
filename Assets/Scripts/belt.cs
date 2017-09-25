using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belt : MonoBehaviour {

	[SerializeField]
	private float beltSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Repeat (Time.deltaTime * beltSpeed, 1);

		Vector2 offset = new Vector2 (x, 0);

		GetComponent<Renderer> ().sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
