using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DarkUI : MonoBehaviour {
	public Image img;
	public Color altColorW = new Color32 (235, 235, 235, 211);
	public Color OrigColor;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
		OrigColor = img.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("DarkMode") == 0) {
			img.color = altColorW;
		} else {
			img.color = OrigColor;
		}
	}
}
