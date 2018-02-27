using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuBack : MonoBehaviour {

	public void bottonPlay(){
	SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
