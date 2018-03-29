using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DarkToggle : MonoBehaviour {
	public Toggle DToggle;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("DarkMode") == 1) {
			DToggle.isOn = true;
		} else {
			DToggle.isOn = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (DToggle.isOn == true) {
			PlayerPrefs.SetInt ("DarkMode", 1);
		} else {
			PlayerPrefs.SetInt ("DarkMode", 0);
		}
	}


}