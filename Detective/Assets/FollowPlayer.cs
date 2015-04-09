using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	private GameObject player;

	void Start () {
		player = GameObject.Find ("Player");
	}

	void Update () {
		Vector3 pos = player.transform.position;

		if (pos.x <= 15.85f)
			pos.x = 15.85f;

		if (pos.y <= 8.5f)
			pos.y = 8.5f;

		pos.z = -10;
		transform.position = pos;
	}
}
