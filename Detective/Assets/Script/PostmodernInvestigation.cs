using UnityEngine;
using System.Collections;

public class PostmodernInvestigation : MonoBehaviour {
	public GameObject player;
	public GameText script;
	public GameObject newspaper;
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			player.GetComponent<Player> ().flipInvestigate();
		}
	}
	
	void OnTriggerStay2D(Collider2D col) {
		if (col.name == "Player" && player.GetComponent<Player>().getInvestigate()) {
			if(Input.GetButton("Interact")) {
				if(gameObject.name == "Lamp Post 1")
					script.setText("Yes, it's a lamp post. Stop laughing.");
				if(gameObject.name == "Trash Can 1")
					script.setText("A banana peel, some papers, and dog poop.");
				if(gameObject.name == "Lamp Post 2")
					script.setText("It's a completely ordinary lamp post.");
				if(gameObject.name == "Trash Can 2")
					script.setText("I'm not quite sure what you're hoping to find.");
				if(gameObject.name == "Lamp Post 3")
					script.setText("Why are these lit in the middle of the day?");
				if(gameObject.name == "Umbrella")
					script.setText("A broken umbrella. Is this still an umbrella?");
				if(gameObject.name == "Bench 1")
					script.setText("I've been walking all day, but I'm not tired at all.");
				if(gameObject.name == "Lamp Post 4")
					script.setText("Is this the most important lamp?");
				if(gameObject.name == "Lamp Post 5")
					script.setText("I am completely utterly lost.");
				if(gameObject.name == "Pond")
					script.setText("I wonder if the fish realize their cage?");
				if(gameObject.name == "Lamp Post 6")
					script.setText("This is the least important lamp post, relatively.");
				if(gameObject.name == "Bench 2")
					script.setText("Huh. Dedicated to AM? Who would do that?");
				if(gameObject.name == "Lamp Post 7")
					script.setText("C'mon. I'm wasting time on a lamp post?");
				if(gameObject.name == "Press")
					newspaper.SetActive(true);
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
