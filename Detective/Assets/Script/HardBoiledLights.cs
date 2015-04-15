using UnityEngine;
using System.Collections;

public class HardBoiledLights : MonoBehaviour {
	private float nextActionTime = 0f;
	private float nextActionTime2 = 1f;

	public float period;
	public GameObject light1;
	public GameObject light2;

	void Update () {
		if (Time.time > nextActionTime) { 
			nextActionTime = Time.time + period; 
			
			if (Random.Range (0, 10) > 3) {
				light1.SetActive(true);
			} else {
				light1.SetActive(false);
			}
		}
		if (Time.time > nextActionTime2) { 
			nextActionTime2 = Time.time + period; 

			if (Random.Range (0, 10) > 2) {
				light2.SetActive(true);
			} else {
				light2.SetActive(false);
			}
		}
	}
}
