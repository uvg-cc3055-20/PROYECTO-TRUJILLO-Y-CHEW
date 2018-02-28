﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){

		SceneManager.LoadScene("Jugabilidad", LoadSceneMode.Single);
	}

	public void QuitGame(){

		Debug.Log ("Quit");
		Application.Quit ();
	}

}
