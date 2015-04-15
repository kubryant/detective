using UnityEngine;
using System.Collections;

public class HardBoiledDetective2 : MonoBehaviour {
	private float offset = 1.895466f;

	public float speed;
	public GameObject script;
	
	void FixedUpdate () {
		if(transform.position.x < offset) {
			Vector3 dPos = transform.position;
			dPos.x += speed;
			transform.position = dPos;
		}
		else {
			script.SetActive(true);
		}
	}
}


