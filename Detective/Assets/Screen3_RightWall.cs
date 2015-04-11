using UnityEngine;
using System.Collections;

public class Screen3_RightWall : MonoBehaviour {

	void Start () {
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			Application.LoadLevel(3);
		}
	}
}
