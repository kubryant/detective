using UnityEngine;
using System.Collections;

public class Watson : MonoBehaviour {
	private GameObject leftBound;
	private bool first = true;

	public float speed;
	public GameText script;
	public GameObject player;
	
	void Start () {
		leftBound = GameObject.Find ("LeftBound");
		player.GetComponent<Player> ().flipMove ();
		script.setText ("Dog: Woof!");
		player.GetComponent<Player> ().Flip ();
		leftBound.SetActive (false);
	}
	
	void FixedUpdate () {
		if(transform.position.x+7 < player.transform.position.x) {
			Vector3 wPos = transform.position;
			wPos.x += speed;
			transform.position = wPos;
		} else if (first) {
			first = false;
			leftBound.SetActive (true);
			player.GetComponent<Player> ().flipMove ();
			script.setText ("");
		}
	}
}
