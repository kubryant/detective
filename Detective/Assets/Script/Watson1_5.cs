using UnityEngine;
using System.Collections;

public class Watson1_5 : MonoBehaviour {
	public float speed;
	public GameObject player;
	
	void FixedUpdate () {
		if(transform.position.x+7 < player.transform.position.x) {
			Vector3 wPos = transform.position;
			wPos.x += speed;
			transform.position = wPos;
		}
	}
}
