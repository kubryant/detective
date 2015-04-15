using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HouseScript : MonoBehaviour {
	private GameText script;
	private float nextActionTime = 0.0f; 
	private List<string> dialogue = new List<string> ();
	private GameObject watson;
	private GameObject detective;
	private GameObject player;
	private GameObject bound;

	public float period;
	public float speed;
	public GameObject travel;

	void Start () {
		script = GameObject.Find("Text").GetComponent<GameText>();
		detective = GameObject.Find("detective");
		watson = GameObject.Find ("Watson");
		player = GameObject.Find ("Player");
		bound = GameObject.Find ("RightBound");
		dialogue.Add ("Detective Niklas: Hi Watson. Glad you could join");
		dialogue.Add ("me. Time of death was approximately 12:30PM.");
		dialogue.Add ("Victim was of German descent between the ages");
		dialogue.Add ("of 20 and 30. He was shot in the chest. Twice.");
		dialogue.Add ("His pants are freshly ironed and his shoes are");
		dialogue.Add ("new. It looks like he was planning on meeting");
		dialogue.Add ("someone. I looked in his closet. He has a large");
		dialogue.Add ("number of thicker winter clothes. It doesn't seem");
		dialogue.Add ("like he's been in this area for long.");
		dialogue.Add ("I found a train ticket to Chicago in his trash.");
		dialogue.Add ("Should we go check it out?");
		dialogue.Add ("");
	}

	private int count = 0;
	private int numDialogue = 12;
	private bool done = false;
	private bool done2 = false;
	private bool flip = false;
	void Update () {
		if (Time.time > nextActionTime && count < numDialogue) { 
			nextActionTime = Time.time + period; 
			script.setText(dialogue[count]);
			count++;
			if(count == numDialogue)
				done = true;
		} else if(done && !done2) {
			player.GetComponent<Player> ().flipMove();
			bound.SetActive(false);
			done2 = true;
		} else if (done && done2) {
			if(detective.transform.position.x < 24) {
				if(!flip) {
					flip = true;
					Vector3 wScale = watson.transform.localScale;
					wScale.x *= -1;
					watson.transform.localScale = wScale;
					Vector3 dScale = detective.transform.localScale;
					dScale.x *= -1;
					detective.transform.localScale = dScale;
				}

				Vector3 wPos = watson.transform.position;
				Vector3 dPos = detective.transform.position;
				wPos.x += speed;
				dPos.x += speed;
				watson.transform.position = wPos;
				detective.transform.position = dPos;
			} else {
				player.GetComponent<Player> ().flipMove();
				bound.SetActive(true);
				travel.SetActive(true);
				done = false;
				done2 = false;
			}
		}
	}
}
