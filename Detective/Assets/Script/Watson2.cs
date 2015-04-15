using UnityEngine;
using System.Collections;

public class Watson2 : MonoBehaviour {
	private GameObject leftBound;
	private bool first = true;

	public float speed;
	public GameText script;
	public GameObject player;
	public GameObject detective;
	public GameObject houseScript;
	
	void Start () {
		leftBound = GameObject.Find ("LeftBound");
		player.GetComponent<Player> ().flipMove ();
		leftBound.SetActive (false);
	}
	
	void FixedUpdate () {
		if(transform.position.x < detective.transform.position.x+2) {
			Vector3 wPos = transform.position;
			wPos.x += speed;
			transform.position = wPos;
		} else if (first) {
			first = false;
			leftBound.SetActive (true);
			player.GetComponent<Player> ().flipMove ();
			Vector3 scale = transform.localScale;
			scale.x *= -1;
			transform.localScale = scale;
			houseScript.SetActive(true);
		}
	}
}
