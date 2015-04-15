using UnityEngine;
using System.Collections;

public class DogWall : MonoBehaviour {
	public GameObject watson;
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			watson.SetActive(true);
			Destroy(gameObject);
		}
	}
}
