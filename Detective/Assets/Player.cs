using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed;

	private float horizontal;

	void Start () {
	}

	void Update () {
		horizontal = Input.GetAxis ("Horizontal");
	}

	void FixedUpdate() {
		float x = 0;
		if(Input.GetButton("Horizontal"))
		   x = speed * horizontal;

		Vector3 pos = transform.position;
		pos.x += x;
		transform.position = pos;
	}
}
