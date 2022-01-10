using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung3 : MonoBehaviour
{
    public Camera RC;
    public Camera paper3Cam;
    private bool switched = false;

    private void Start()
    {
        paper3Cam.GetComponent<Camera>().enabled = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }

    private void OnMouseEnter()
    {
        if (GameObject.Find("ETObj3") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    private void OnMouseExit()
    {
        if (GameObject.Find("ETObj3") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (GameObject.Find("ETObj3") == null && switched == false)
        {
            paper3Cam.GetComponent<Camera>().enabled = true;
            RC.GetComponent<Camera>().enabled = false;
            switched = true;
        }
    }
}
