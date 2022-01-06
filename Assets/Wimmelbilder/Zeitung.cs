using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung : MonoBehaviour
{
    public Camera cam1;
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

    public void OnMouseEnter()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj") == null)
            {
                gameObject.GetComponent<Outline>().enabled = true;
            }
        }
    }
    
    public void OnMouseExit()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj") == null)
            {
                gameObject.GetComponent<Outline>().enabled = false;
            }
        }
    }

    public void OnMouseDown()
    {
        if (switched == false)
        {
            if (GameObject.Find("ETObj") == null)
            {
                CameraSwitch();
            }
        }
    }

    private void CameraSwitch()
    {
        paperCam.GetComponent<Camera>().enabled = true;
        cam1.GetComponent<Camera>().enabled = false;
        switched = true;
    }
}
