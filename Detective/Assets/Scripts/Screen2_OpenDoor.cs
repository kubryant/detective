using UnityEngine;
using System.Collections;

public class Screen2_OpenDoor : MonoBehaviour {

	void Start () {
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			Debug.Log(col.gameObject.transform.position.x);
			Application.LoadLevel(2);
		}
	}
}
