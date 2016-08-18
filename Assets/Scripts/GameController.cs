using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public bool isPaused;

	public void PauseButton () {
		isPaused = !isPaused;
		if (isPaused) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = 0;
		}
	}
}
