using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThemeMusic : MonoBehaviour {
	Scene currenctscene;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
		currenctscene = SceneManager.GetActiveScene ();

		if (currenctscene.name == "Start") {
			Destroy (this.gameObject);
		}
		if (currenctscene.name == "Options") {
			Destroy (this.gameObject);
		}
		if (currenctscene.name == "Share") {
			Destroy (this.gameObject);
		}
	}
}
