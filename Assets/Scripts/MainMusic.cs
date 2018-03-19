using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMusic : MonoBehaviour {
	Scene currenctscene;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject.transform);
	}

	// Update is called once per frame
	void Update () {
		currenctscene = SceneManager.GetActiveScene ();

		if (currenctscene.name == "Test") {
			Destroy (this.gameObject);
		}
		if (currenctscene.name == "Maze") {
			Destroy (this.gameObject);
		}
		if (currenctscene.name == "Brug") {
			Destroy (this.gameObject);
		}
		if (currenctscene.name == "Intro") {
			Destroy (this.gameObject);
		}
	}
}