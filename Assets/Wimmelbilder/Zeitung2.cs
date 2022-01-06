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

    public void OnMouseEnter()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj2") == null)
            {
                gameObject.GetComponent<Outline>().enabled = true;
            }
        }
    }

    public void OnMouseExit()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj2") == null)
            {
                gameObject.GetComponent<Outline>().enabled = false;
            }
        }
    }

    public void OnMouseDown()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj2") == null)
            {
                CameraSwitch();
            }
        }
    }

    private void CameraSwitch()
    {
        paper2Cam.GetComponent<Camera>().enabled = true;
        ET.GetComponent<Camera>().enabled = false;
        switched = true;
    }
}
