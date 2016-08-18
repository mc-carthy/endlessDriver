using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 5f;

	private SpriteRenderer sr;

	private void Start () {
		transform.localRotation = Quaternion.Euler (new Vector3 (0f, 0f, 180f));
		transform.localScale = new Vector3 (0.8f, 0.8f, 1f);
		Invoke ("Destroy", 4f);
	}

	private void Update () {
		transform.Translate (new Vector3 (0f, 1f, 0f) * speed * Time.deltaTime);
	}

	private void Destroy () {
		Destroy (this.gameObject);
	}
}
