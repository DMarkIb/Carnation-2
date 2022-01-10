using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung2 : MonoBehaviour
{
    public Camera ET;
    public Camera paper2Cam;
    private bool switched = false;

    private void Start()
    {
        paper2Cam.GetComponent<Camera>().enabled = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }

    //Siehe Zeitung.cs für Kommentare
    private void OnMouseEnter()
    {
        if (GameObject.Find("ETObj2") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    private void OnMouseExit()
    {
        if (GameObject.Find("ETObj2") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (GameObject.Find("ETObj2") == null && switched == false)
        {
            paper2Cam.GetComponent<Camera>().enabled = true;
            ET.GetComponent<Camera>().enabled = false;
            switched = true;
        }
    }
}
