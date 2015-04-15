using UnityEngine;
using System.Collections;

public class Woman2 : MonoBehaviour {
	private GameText script;
	
	void Start () {
		script = GameObject.Find("Text").GetComponent<GameText>();
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		script.setText ("Woman: Oh, my. Watson is such a cute dog!");
	}

	void OnTriggerExit2D(Collider2D col) {
		script.setText ("");
	}
}
