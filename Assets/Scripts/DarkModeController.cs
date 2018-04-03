using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DarkModeController : MonoBehaviour {
	public Renderer rend;
	public Color altColor = Color.white;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("DarkMode") == 0) {
			rend = GetComponent<Renderer> ();
			rend.material.color = altColor;
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
