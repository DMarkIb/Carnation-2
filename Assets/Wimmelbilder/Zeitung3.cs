using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung3 : MonoBehaviour
{
    public Camera RC;
    public Camera paper3Cam;
    private bool switched = false;

    void Start()
    {
        paper3Cam.GetComponent<Camera>().enabled = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {

    }

    public void OnMouseEnter()
    {
        if (GameObject.Find("ETObj3") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    public void OnMouseExit()
    {
        if (GameObject.Find("ETObj3") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    public void OnMouseDown()
    {
        if (GameObject.Find("ETObj3") == null && switched == false)
        {
            CameraSwitch();
        }
    }

    private void CameraSwitch()
    {
        paper3Cam.GetComponent<Camera>().enabled = true;
        RC.GetComponent<Camera>().enabled = false;
        switched = true;
    }
}
