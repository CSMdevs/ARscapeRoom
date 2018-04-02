using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NLENScript : MonoBehaviour {
	public Text changeText;
	public string Nederlands;
	public string Engels;
	// Use this for initialization
	void Start () {
		changeText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetFloat ("Taal") == 0f) {
			changeText.text = Engels;
		} else {
			changeText.text = Nederlands;
		}
	}
}
