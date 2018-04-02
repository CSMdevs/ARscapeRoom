using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Url() {
		Application.OpenURL("https://github.com/CSMdevs/ARscapeRoom/raw/master/Slot.JPG");
	}
}
