using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AlleyScript : MonoBehaviour {
	private GameText script;
	private float nextActionTime = 0.0f; 
	private List<string> dialogue = new List<string> ();
	private bool punch = false;
	private bool reset = false;
	private float speed = .5f;

	public float period;
	public GameObject player;
	public GameObject detective;
	public GameObject car;

	void Start () {
		script = GameObject.Find("Text").GetComponent<GameText>();
		player.GetComponent<Player> ().setInvestigate ();
		dialogue.Add ("Baldy: You ain't who I was waiting for.");
		dialogue.Add ("Who are you? Get outta here if you don't");
		dialogue.Add ("wanna get hurt.");
		dialogue.Add ("Niklas: Where were you yesterday around 12:30?");
		dialogue.Add ("Baldy: You a copper? I got nothing for you.");
		dialogue.Add ("Niklas: PUNCH");
		dialogue.Add ("Niklas: Where were you yesterday around 12:30?");
		dialogue.Add ("Baldy: Eat a boot.");
		dialogue.Add ("Niklas: PUNCH");
		dialogue.Add ("Baldy: Cough.. Cough..");
		dialogue.Add ("It wasn't me. That brown haired kid had it comin'.");
		dialogue.Add ("But, it wasn't me. I ain't no snitch, but I know");
		dialogue.Add ("someone who can tell you more.");
		dialogue.Add ("Let's take a drive.");
		dialogue.Add ("");
	}
	
	private int count = 0;
	private int numDialogue = 15;
	void Update () {
		if (Time.time > nextActionTime && count < numDialogue) { 
			nextActionTime = Time.time + period; 
			script.setText(dialogue[count]);
			count++;
			if(count == 6 || count == 9)
				punch = true;
			if(count == 15)
				car.SetActive(true);
		}
		if (punch) {
			if(!reset && detective.transform.position.x < 5f) {
				Vector3 dPos = detective.transform.position;
				dPos.x += speed;
				detective.transform.position = dPos;

				if(dPos.x > 5f)
					reset = true;
			} else if (reset && detective.transform.position.x > 1.895466f) {
				Vector3 dPos = detective.transform.position;
				dPos.x -= speed;
				detective.transform.position = dPos;
			} else {
				punch = false;
				reset = false;
			}
		}
	}
}