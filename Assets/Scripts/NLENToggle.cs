using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NLENToggle : MonoBehaviour {
	public Slider slider;
	public int sliderVal;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat ("Taal") == 0f) {
			slider.value = 0f;
		} else {
			slider.value = 1f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SubmitSliderSetting()
	{
		
		//Displays the value of the slider in the console.

		PlayerPrefs.SetFloat ("Taal", slider.value);
	}
}
