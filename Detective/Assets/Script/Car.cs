using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	private bool pickUp = false;
	private bool drive2 = false;
	private float nextActionTime = 0.0f; 
	private int count = 0;

	public float period;
	public float speed;
	public GameObject detective;
	public GameObject watson;
	public GameObject baldy;
	public GameObject travel;

	void FixedUpdate () {
		if(!pickUp && transform.position.x < 4.22f) {
			Vector3 cPos = transform.position;
			cPos.x += speed;
			transform.position = cPos;

			if(cPos.x > 4.22f)
				pickUp = true;
		} else if(pickUp) {
			if (Time.time > nextActionTime) { 
				count++;
				nextActionTime = Time.time + period; 

				if(count == 1) {
					Destroy(detective);
					Destroy(watson);
					Destroy (baldy);
				} else if(count == 2) {
					drive2 = true;
					pickUp = false;
				}
			}
		} else if (!pickUp && drive2) {
			Vector3 cPos = transform.position;
			cPos.x += speed;
			transform.position = cPos;

			if(cPos.x > 20f)
				travel.SetActive(true);
		}
	}
}
