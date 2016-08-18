using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 5f;

	private void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
}
