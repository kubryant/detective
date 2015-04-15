using UnityEngine;
using System.Collections;

public class Watson3 : MonoBehaviour {
	public float speed;
	public GameObject detective;

	void FixedUpdate () {
		if(transform.position.x+5 < detective.transform.position.x) {
			Vector3 wPos = transform.position;
			wPos.x += speed;
			transform.position = wPos;
		}
	}
}
