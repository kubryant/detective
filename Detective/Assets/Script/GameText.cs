using UnityEngine;
using System.Collections;

public class GameText : MonoBehaviour {

	private bool over = false;

	void Start () {
		Vector3 pos = new Vector3 (-15f, -13.8f, 0f);
		Vector3 gPos = Camera.main.WorldToViewportPoint (pos);
		transform.position = gPos;
	}

	public void setText(string text) {
		guiText.text = text;
	}
	
	void OnMouseDown() {
		if(over)
			Application.LoadLevel (1);
	}

	public void setOver() {
		over = !over;
	}
}
