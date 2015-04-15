using UnityEngine;
using System.Collections;

public class HardBoiledDetective : MonoBehaviour {
	public float speed;

	void FixedUpdate () {
		Vector3 dPos = transform.position;
		dPos.x += speed;
		transform.position = dPos;
	}
}
