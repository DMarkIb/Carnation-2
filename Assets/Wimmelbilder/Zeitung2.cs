using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung2 : MonoBehaviour
{
    public Camera ET;
    public Camera paper2Cam;
    private bool switched = false;

    void Start()
    {
        paper2Cam.GetComponent<Camera>().enabled = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {

    }
    //Siehe Zeitung.cs für Kommentare
    public void OnMouseEnter()
    {
        if (GameObject.Find("ETObj2") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    public void OnMouseExit()
    {
        if (GameObject.Find("ETObj2") == null && switched == false)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    public void OnMouseDown()
    {
        if (GameObject.Find("ETObj2") == null && switched == false)
        {
            CameraSwitch();
        }
    }

    private void CameraSwitch()
    {
        paper2Cam.GetComponent<Camera>().enabled = true;
        ET.GetComponent<Camera>().enabled = false;
        switched = true;
    }
}
