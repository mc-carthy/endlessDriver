using UnityEngine;
using System.Collections;

public class RoadController : MonoBehaviour {

	public float speed;

	private Vector2 offset;
	private Renderer ren;

	private void Start () {
		ren = GetComponent<Renderer> ();
	}


	private void Update () {
		offset = new Vector2 (0, speed * Time.time);
		ren.material.mainTextureOffset = offset;
	}

}
