using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

	public bool isPaused;
	public bool isPlayerDead;
	public GameObject pauseScreen;
	public AudioManager am;

	private void Start () {
		pauseScreen.SetActive (false);
		am = FindObjectOfType<AudioManager> ();
		am.carSound.Play ();
	}

	public void PauseButton () {
		isPaused = !isPaused;
		if (isPaused) {
			Time.timeScale = 0;
			pauseScreen.SetActive (true);
			am.carSound.Stop ();
		} else {
			Time.timeScale = 1;
			pauseScreen.SetActive (false);
			am.carSound.Stop ();
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
