using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void Play() {
		SceneManager.LoadScene ("Game");
	}
	
	// Update is called once per frame
	void Quit() {
		Application.Quit ();
	}
}
