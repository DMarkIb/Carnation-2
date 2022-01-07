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
        if (switched == false)
        {
            if (GameObject.Find("ETObj3") == null)
            {
                gameObject.GetComponent<Outline>().enabled = true;
            }
        }
    }

    public void OnMouseExit()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj3") == null)
            {
                gameObject.GetComponent<Outline>().enabled = false;
            }
        }
    }

    public void OnMouseDown()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj3") == null)
            {
                CameraSwitch();
            }
        }
    }

    private void CameraSwitch()
    {
        paper3Cam.GetComponent<Camera>().enabled = true;
        RC.GetComponent<Camera>().enabled = false;
        switched = true;
    }
}
