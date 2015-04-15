using UnityEngine;
using System.Collections;

public class Wallet : MonoBehaviour {
	public GameObject license;
	public GameObject player;

	private GameText script;

	void Start () {
		script = GameObject.Find("Text").GetComponent<GameText>();
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			player.GetComponent<Player> ().flipInvestigate();
		}
	}
	void OnTriggerStay2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			if(Input.GetButton("Interact")) {
				script.setText ("Stranger: Hey! This is my wallet!");
				license.SetActive (true);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			player.GetComponent<Player> ().flipInvestigate();
			script.setText("");
		}
	}
}
