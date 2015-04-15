using UnityEngine;
using System.Collections;

public class GameText : MonoBehaviour {

	void Start () {
		Vector3 pos = new Vector3 (-21f, -13.8f, 0f);
		Vector3 gPos = Camera.main.WorldToViewportPoint (pos);
		transform.position = gPos;
	}

	public void setText(string text) {
		guiText.text = text;
	}
}
