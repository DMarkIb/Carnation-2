using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitungFin : MonoBehaviour
{
    public Camera cam1;
    public Camera paperCam;
    public Camera mainCam;

    public GameObject Spieler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Debug.Log("Cam Switch");
        cam1.GetComponent<Camera>().enabled = false;
        paperCam.GetComponent<Camera>().enabled = false;
        mainCam.GetComponent<Camera>().enabled = true;
        Spieler.SetActive(true);
        GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
    }
}
