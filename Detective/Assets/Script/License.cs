using UnityEngine;
using System.Collections;

public class License : MonoBehaviour {
	private GameText script;
	private GameObject player;
	private GameObject wallet;

	void Start () {
		script = GameObject.Find("Text").GetComponent<GameText>();
		player = GameObject.Find ("Player");
		wallet = GameObject.Find ("Wallet");
		player.GetComponent<Player> ().flipMove ();
		player.GetComponent<Player> ().flipInvestigate ();
	}
	
	void Update () {
		if(Input.GetButton("Close")) {
			player.GetComponent<Player> ().flipMove ();
			script.setText("");
			Destroy (wallet, 0.2f);
			Destroy(gameObject);
		}
	}
}
