using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FirstTime : MonoBehaviour {
	public string SceneToLoad;
	public Canvas test;
	// Use this for initialization
	void Start () {
		test.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Joepie() {
		test.enabled = true;
	}
	public void TapToStart (){
		SceneManager.LoadScene (SceneToLoad);
		Debug.Log("Start");
	}
}
