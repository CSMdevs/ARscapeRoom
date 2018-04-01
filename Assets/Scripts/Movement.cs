using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    //where the player wants the block to move to
    public Vector3 whereToGo;
    //where the block is right now
    public Vector3 whereAmI;
    //where the block was before it moved
    public Vector3 whereIWas;
    //the rb
    public Rigidbody rb;
    //how fast the block can go
    public float speed;
    //i for not to fast clicking, that causes bugs
    public int i = 0;
    //what number to hit
    public int toHit;
    //For when failed
    public Canvas failed;
    //For when finished
    public Canvas finished;
    //Explain canvas
    public Canvas explain;
    //Buttons canvas
    public Canvas buttons;

    

    void Awake()
    {
        //not a to fast framerate for i
        Application.targetFrameRate = 30;
    }

    void Start()
    {
        //no failed of finished on beginning
        failed.enabled = false;
        finished.enabled = false;
        buttons.enabled = false;
        //set if not already done
        PlayerPrefs.SetInt("toHit", 1);
        //what thing to hit
        toHit = PlayerPrefs.GetInt("toHit", 1);
        //get rb for movement
        rb = GetComponent<Rigidbody>();
        //no movement on start
        whereToGo = transform.position;
        //save start location for colliding
        SaveLocation();
    }

    void Update()
    {
        //no weird numbers, because it'll cause bugs
        whereAmI.x = Mathf.Round(transform.position.x*10)/10;
        whereAmI.y = Mathf.Round(transform.position.y*10)/10;
        whereAmI.z = Mathf.Round(transform.position.z*10)/10;
        //to know when movement is allowed
        i--;
        Debug.Log("Have to hit: "+toHit.ToString());
        //what thing to hit
        toHit = PlayerPrefs.GetInt("toHit");
        //auto save location when standing for a while
        if (i < -10)
        {
            SaveLocation();
        }
        
    }

    private void FixedUpdate()
    {
        //the automovement to the right position
        if ((Mathf.Round(whereAmI.z * 5) / 5) < Mathf.Round(whereToGo.z*5)/5)
        {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
        }
        if ((Mathf.Round(whereAmI.z * 5) / 5) > Mathf.Round(whereToGo.z*5)/5)
        {
            rb.MovePosition(transform.position - transform.forward * Time.deltaTime * speed);
        }
        if ((Mathf.Round(whereAmI.x * 5) / 5) < Mathf.Round(whereToGo.x*5)/5)
        {
            rb.MovePosition(transform.position + transform.right * Time.deltaTime * speed);
        }
        if ((Mathf.Round(whereAmI.x * 5) / 5) > Mathf.Round(whereToGo.x*5)/5)
        {
            rb.MovePosition(transform.position - transform.right * Time.deltaTime * speed);
         }

    }
    void OnCollisionEnter(Collision col)
    {
        //to test hits
        Debug.Log("I've been hit");
        if (col.gameObject.tag == "Target")
        {
            if (toHit.ToString() == rb.name)
            {
                //to know what has been hit
                Debug.Log("I've registerd the hit");
                if (toHit + 1 == 7)
                {
                    Debug.Log("You finished the game");
                    finished.enabled = true;
                    buttons.enabled = false;
                    Destroy(col.gameObject);
                    whereToGo.y = 100;
                    transform.position = whereToGo;

                }
                else
                {
                    PlayerPrefs.SetInt("toHit", (toHit + 1));
                    Destroy(col.gameObject);
                    Destroy(gameObject);
                }
            }
            else
            {
                //what to do when wrong target was hit
                Debug.Log("Wrong thing hit their target");
                //show failed canvas
                failed.enabled = true;
                buttons.enabled = false;
            }
        } else if (col.gameObject.tag == "Blocks")
        {
            //what happens when hitting another block
            whereToGo = whereIWas;
            transform.position = whereIWas;
            SaveLocation();
        }
        
            
        
    }
    //Control for the buttons, and that doesn't go through walls
    public void GoUp() {
        if (i > 0)
        {
            Debug.Log("To soon");
        }
        else if (whereToGo.z + 1 < 3)
        {
            SaveLocation();
            whereToGo.z++;
            i = 15;
        } else
        {
            Debug.Log("not allowed");
        }
    }
    public void GoDown() {
        if (i > 0)
        {
            Debug.Log("To soon");
        }
        else if (whereToGo.z - 1 > -3)
        {
            SaveLocation();
            whereToGo.z--;
            i = 15;
        }
    }
    public void GoLeft() {
        if (i > 0)
        {
            Debug.Log("To soon");
        }
        else if (whereToGo.x - 1 > -3)
        {
            SaveLocation();
            whereToGo.x--;
            i = 15;
        }
    }
    public void GoRight() {
        if (i > 0)
        {
            Debug.Log("To soon");
        }
        else if (whereToGo.x + 1 < 3)
        {
            SaveLocation();
            whereToGo.x++;
            i = 15;
        }
    }
    public void SaveLocation() {
        //to know the old position for when hit
        whereIWas.x = Mathf.Round(transform.position.x);
        whereIWas.y = Mathf.Round(transform.position.y);
        whereIWas.z = Mathf.Round(transform.position.z);
    }
    //UIthings
    public void ReloadLevel() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
    public void NextLevel() { SceneManager.LoadScene("Intro"); }
    public void StartGame() { explain.enabled = false; buttons.enabled = true; }
}
