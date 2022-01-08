using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung : MonoBehaviour
{
    public Camera CT;
    public Camera paperCam;
    private bool switched = false;

    void Start()
    {
        paperCam.GetComponent<Camera>().enabled = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {
        
    }

    //Outlines erst sichtbar, wenn alle objecte weg bewegt und dann automatisch gel�scht wurden
    public void OnMouseEnter()
    {
        if (GameObject.Find("ETObj") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }
    
    public void OnMouseExit()
    {
        if (GameObject.Find("ETObj") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    public void OnMouseDown()
    {
        if (GameObject.Find("ETObj") == null && switched == false)
        {
            paperCam.GetComponent<Camera>().enabled = true; //Wenn Zeitung angeklickt und WM erledigt wurde, switchted die Camera auf ein Close up
            CT.GetComponent<Camera>().enabled = false;
            switched = true; 
        }
    }
}
