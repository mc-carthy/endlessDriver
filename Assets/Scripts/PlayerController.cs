using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float xSpeed;

	private Vector2 pos;
	private float xClamp = 2.2f;

	private void Start () {
		pos = transform.position;
	}

	private void Update () {
		pos.x += Input.GetAxisRaw ("Horizontal") * xSpeed * Time.deltaTime;
		pos.x = Mathf.Clamp (pos.x, -xClamp, xClamp);
		transform.position = pos;
	}

	private void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "enemy") {
			Destroy (this.gameObject);
		}
	}
}
