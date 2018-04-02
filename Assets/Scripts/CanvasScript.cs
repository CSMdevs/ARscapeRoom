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
        Debug.Log("Start");
	}
	public void TapToOptions (){
		SceneManager.LoadScene (OptionsToLoad);
        Debug.Log("Options");
	}
	public void TapToShare (){
		SceneManager.LoadScene (ShareToLoad);
        Debug.Log("Share");
	}
}
