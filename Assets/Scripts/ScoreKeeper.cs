using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public float score;
	public Text scoreText;


	private float scoreMultiplier = 10f;
	private GameController gc;

	private void Start () {
		gc = FindObjectOfType<GameController> ();
	}

	private void Update () {
		if (!gc.isPlayerDead) {
			score += Time.deltaTime * scoreMultiplier;
			scoreText.text = "Score: " + ((int)score).ToString ("D3");
		}
	}
}
