using UnityEngine;
using System.Collections;

public class Screen2_OpenDoor : MonoBehaviour {
	public Sprite openDoor;
	public GameText script;
	public GameObject player;
	public GameObject woman;

	void Start () {
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			GameObject.Find("BG").GetComponent<SpriteRenderer>().sprite = openDoor;
			player.GetComponent<Player> ().flipMove ();
			woman.SetActive(true);
			Destroy (gameObject);
		}
	}
}
