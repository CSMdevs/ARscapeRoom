using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasScript : MonoBehaviour {

	public string SceneToLoad;
	public string OptionsToLoad;
	public string ShareToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void TapToStart (){
		SceneManager.LoadScene (SceneToLoad);
	}
	public void TapToOptions (){
		SceneManager.LoadScene (OptionsToLoad);
	}
	public void TapToShare (){
		SceneManager.LoadScene (ShareToLoad);
	}
}
