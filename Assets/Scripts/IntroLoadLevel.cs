using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Scripting;

public class IntroLoadLevel : MonoBehaviour {
    public string PartOne = "1BrugGame";
    public string PartTwo = "2BlokGame";
    public string PartThree = "3MazeGame";
	public string PartFour = "4BkeGame";
    public string home = "Start";
    public Text CompletedOne;
    public Text CompletedTwo;
    public Text CompletedThree;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("Deel1") == 1)
        {
            CompletedOne.enabled = true;
        }
        else
        {
            CompletedOne.enabled = false;
        }
        if (PlayerPrefs.GetInt("Deel2") == 1)
        {
            CompletedTwo.enabled = true;
        }
        else
        {
            CompletedTwo.enabled = false;
        }
        if (PlayerPrefs.GetInt("Deel3") == 1)
        {
            CompletedThree.enabled = true;
        }
        else
        {
            CompletedThree.enabled = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void LoadPartOne() {
        SceneManager.LoadScene(PartOne);
    }
    public void LoadPartTwo() {
        SceneManager.LoadScene(PartTwo);
    }
    public void LoadPartThree() {
        SceneManager.LoadScene(PartThree);
    }
	public void LoadPartFour() {
		SceneManager.LoadScene(PartFour);
	}
    public void LoadHome() {
        SceneManager.LoadScene(home);
    }
}
