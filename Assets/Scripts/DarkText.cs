using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DarkText : MonoBehaviour {
	public Text tekst;
	public Color altColor = new Color32 (242, 242, 242, 240);
	public Color OriginColor;
	// Use this for initialization
	void Start () {
		tekst = GetComponent<Text> ();
		OriginColor = tekst.color;
	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("DarkMode") == 0) {
			tekst.color = altColor;
		} else {
			tekst.color = OriginColor;
		}
	}
}
