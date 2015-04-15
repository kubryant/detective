using UnityEngine;
using System.Collections;

public class Newspaper : MonoBehaviour {
	
	private GameObject player;
	public GameObject final;
	
	void Start () {
		player = GameObject.Find ("Player");
		player.GetComponent<Player> ().flipMove ();
		player.GetComponent<Player> ().flipInvestigate ();
	}
	
	void Update () {
		if(Input.GetButton("Close")) {
			final.SetActive(true);
			Destroy(gameObject);
		}
	}
}