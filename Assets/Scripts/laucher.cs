using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laucher : MonoBehaviour {

	public GameObject potato;

	IEnumerator Start ()
	{
		while (true) {
			// 芋を大砲と同じ位置/角度で作成
			Instantiate (potato, transform.position, transform.rotation);
			// 1秒待つ
			yield return new WaitForSeconds (1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
