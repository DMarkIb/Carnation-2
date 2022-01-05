using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeitung : MonoBehaviour
{
    public Camera cam1;
    public Camera paperCam;
    public Camera mainCam;

    public GameObject Spieler;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;

        mainCam.GetComponent<Camera>().enabled = false;
        paperCam.GetComponent<Camera>().enabled = false;
        cam1.GetComponent<Camera>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseEnter()
    {
        if (GameObject.Find("Tassen").GetComponent<Tassen>().counter == 8)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
            
    }
    
    public void OnMouseExit()
    {
        if (GameObject.Find("Tassen").GetComponent<Tassen>().counter == 8)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    public void OnMouseDown()
    {
            if (GameObject.Find("Tassen").GetComponent<Tassen>().counter == 8)
            {
            //Debug.Log("yes");

            paperCam.GetComponent<Camera>().enabled = true;
            cam1.GetComponent<Camera>().enabled = false;            
            }
    }
}
