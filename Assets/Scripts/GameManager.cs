﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	bool gamehasended=false;
	public float restartdelay = 1f;
	public GameObject completelevelUI;

	public void CompleteLevel()
	{	completelevelUI.SetActive (true);
	}
	public void EndGame(){

		if (gamehasended == false) {
			gamehasended = true;
			Debug.Log ("game over");
			Invoke ("Restart",restartdelay);
		}
	}

	void Restart(){

		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
