using UnityEngine;
using System.Collections;

public class Woman : MonoBehaviour {
	private bool first = true;

	public GameObject player;
	public GameText script;
	public float speed;

	void FixedUpdate () {
		if(transform.position.x > -30) {
			Vector3 wPos = transform.position;
			wPos.x -= speed;
			transform.position = wPos;

			if(transform.position.x < 20 && first)
				script.setText("Woman: Looks like Watson's on another case!");
			if(transform.position.x < -1 && first) {
				player.GetComponent<Player> ().flipMove ();
				first = false;
				script.setText("");
			}
		}
	}
}
