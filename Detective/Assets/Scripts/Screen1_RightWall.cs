using UnityEngine;
using System.Collections;

public class Screen1_RightWall : MonoBehaviour {

	void Start () {
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			Application.LoadLevel(1);
		}
	}
}
