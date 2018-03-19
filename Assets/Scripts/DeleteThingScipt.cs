using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeleteThingScipt : MonoBehaviour {
    public GameObject[] ThingToDestroy;
    public Renderer[] ThingToChange;
    public bool[] DestroyThis;
    public Material SelectColor;
    public Material NonSelectColor;
    public Material SelectedColor;
    public Material DualSelectColor;
    public Canvas Finished;
    public Canvas Failed;
    public Canvas Explanation;
    public Canvas Controls;
    private int i;
    public int maxNumber = 13;

    void Start() {
        Reload();
        Finished.enabled = false;
        Failed.enabled = false;
        Controls.enabled = false;
        Explanation.enabled = true;
    }

    void Update() {
    }
    public void BackToIntro() {
        SceneManager.LoadScene("Intro");
    }
    public void TapToStart() {
        Explanation.enabled = false;
        Controls.enabled = true;
    }
    public void DestroyObject() {
        IsDestroyed();
        ReadyToDestroy();
    }

    public void Reload() {
        SelectObject();
    }
    public void DestroyButton() {
        StartCoroutine(CheckLevelDone());
        for (int ger = 0; ger < 100; ger++)
        {
            if (DestroyThis[ger] == true)
            {
                Destroy(ThingToDestroy[ger]);
            }
        }
    }

    void IsDestroyed() {
        if (DestroyThis[i] == false)
        {
            DestroyThis[i] = true;
        }
        else
        {
            DestroyThis[i] = false;
        }
    }

    void ReadyToDestroy() {
        if (DestroyThis[i] == true)
        {
            ThingToChange[i].material = DualSelectColor;
        }
        else
        {
            ThingToChange[i].material = SelectColor;
        }
    }

    void SelectObject()
    {
        if (DestroyThis[i] == false) {
            ThingToChange[i].material = SelectColor;
        } else {
            ThingToChange[i].material = DualSelectColor;
        }
    }
   
    void ChangeColor() {
        if (DestroyThis[i] == false) {
            ThingToChange[i].material = NonSelectColor;
        } else {
            ThingToChange[i].material = SelectedColor;
        }
    }

    IEnumerator CheckLevelDone() {
        if (DestroyThis[5] == true && DestroyThis[7] == true && DestroyThis[8] == true && DestroyThis[9] == true && DestroyThis[11] == true)
        {
            Debug.Log("Je hebt hebt het level gehaald");
            yield return new WaitForSeconds(3);
            Finished.enabled = true;
            Controls.enabled = false;
            PlayerPrefs.SetInt("Deel3", 1);
        }
        else
        {
            Debug.Log("Je hebt hebt het level verpest!");
            yield return new WaitForSeconds(3);
            Failed.enabled = true;
            Controls.enabled = false;
        }
    }


    //Voor de pijltjes
    public void SelectUp()
    {
        if (i+1 == maxNumber)
        {
            Debug.Log("Mag niet");
        } else {
            ChangeColor();
            i++;
            Reload();
            Debug.Log("Gelukt!");
        }
    }

    public void SelectDown()
    {
        if (i-1 == -1)
        {
            Debug.Log("Mag niet");
        }
        else
        {
            ChangeColor();
            i--;
            Reload();
            Debug.Log("Gelukt");
        }
    }
    public void VerderAlsGefaald() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

}
