using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

	public bool isPaused;
	public GameObject pauseScreen;

	private void Start () {
		pauseScreen.SetActive (false);
	}

	public void PauseButton () {
		isPaused = !isPaused;
		if (isPaused) {
			Time.timeScale = 0;
			pauseScreen.SetActive (true);
		} else {
			Time.timeScale = 1;
			pauseScreen.SetActive (false);
		}
	}

	public void GoToMainMenu () {
		SceneManager.LoadScene ("Menu");
	}

	public void LoadMainScene () {
		SceneManager.LoadScene ("Main");
	}

	public void ReloadMainScene () {
		SceneManager.LoadScene ("Main");
		PauseButton ();
	}

	public void QuitGame () {
		Application.Quit ();
	}
}
