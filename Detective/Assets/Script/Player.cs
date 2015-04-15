using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed;
	public float offset;

	private bool facingRight = true;
	private float horizontal;
	private GUIText investigate;
	private bool investigateEnabled = false;
	private bool canMove = true;
	private bool canInvestigate = true;

	void Start () {
		investigate = GameObject.Find ("Investigate").guiText;
		investigate.enabled = false;
	}

	void Update () {
		horizontal = Input.GetAxis ("Horizontal");

		Vector3 guiPos = investigate.transform.position;
		Vector3 playerPos = transform.position;
		playerPos.y += offset;
		guiPos = Camera.main.WorldToViewportPoint (playerPos);
		investigate.transform.position = guiPos;
	}

	void FixedUpdate() {
		if(canMove) {
			float x = 0;
			if(Input.GetButton("Horizontal")) {
				if(horizontal < 0 && facingRight)
					Flip ();
				else if (horizontal > 0 && !facingRight)
					Flip ();

				x = speed * horizontal;
			}

			Vector3 pos = transform.position;
			pos.x += x;
			transform.position = pos;
		}
	}

	public void Flip() {
		facingRight = !facingRight;

		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}

	public void FlipLeft() {
		if (facingRight) {
			Flip ();
		}
	}

	public void flipInvestigate() {
		investigateEnabled = !investigateEnabled;
		investigate.enabled = investigateEnabled;
	}

	public void flipMove() {
		canMove = !canMove;
	}

	public void setInvestigate() {
		if (canInvestigate)
			flipInvestigate ();

		canInvestigate = !canInvestigate;
	}

	public bool getInvestigate() {
		return canInvestigate;
	}
}
