using UnityEngine;
using System.Collections;

public class TravelRight : MonoBehaviour {
	public int nextLevel;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			Application.LoadLevel(nextLevel);
		}
	}
}
