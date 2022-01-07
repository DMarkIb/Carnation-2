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
            CameraSwitch();
        }
    }

    private void CameraSwitch()
    {
        paperCam.GetComponent<Camera>().enabled = true;
        CT.GetComponent<Camera>().enabled = false;
        switched = true;
    }
}
