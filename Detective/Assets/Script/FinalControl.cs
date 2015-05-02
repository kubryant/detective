using UnityEngine;
using System.Collections;

public class FinalControl : MonoBehaviour {
	public GameObject player;
	public GameObject bench;
	public Sprite back;
	public GameText script;

	private int phase = 0;

	void FixedUpdate () {
		player.GetComponent<Player>().FlipLeft();
		if(phase == 0 && player.transform.position.x > 1f) {
			Vector3 pos = player.transform.position;
			pos.x -= 0.12f;
			player.transform.position = pos;

			if(player.transform.position.x < 1f)
				phase++;
		} else if (phase == 1) {
			Vector3 pos = player.transform.position;
			pos.y += 0.12f;
			player.transform.position = pos;
			
			if(player.transform.position.y > -1.657f)
				phase++;
		} else if (phase == 2) {
			bench.GetComponent<SpriteRenderer>().renderer.sortingOrder = 3;
			
			Vector3 pos = player.transform.position;
			pos.x -= 0.12f;
			player.transform.position = pos;
			
			if(player.transform.position.x < -9f)
				phase++;
		} else if (phase == 3) {
			player.GetComponent<SpriteRenderer>().sprite = back;
			script.setText("The End - Play Again?");
			script.setOver();
			phase++;
		}
	}
}
