using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour {
	public GameObject player;
	public GameText script;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			player.GetComponent<Player> ().flipInvestigate();
		}
	}

	void OnTriggerStay2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			if(Input.GetButton("Interact")) {
				if(gameObject.name == "Boxes") 
					script.setText("Looks like someone's been living here.");
				else if(gameObject.name == "Door")
					script.setText("I can hear the sound of banging hammers.");
				else if(gameObject.name == "Trash")
					script.setText("This could be the perfect place to hide a body.");
				else if(gameObject.name == "Pipe")
					script.setText("I have an urge to smash these pipes for fun.");
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
