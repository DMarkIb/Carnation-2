using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitungFin2 : MonoBehaviour
{
    public Camera paper2Cam;
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
        paper2Cam.GetComponent<Camera>().enabled = false;
        mainCam.GetComponent<Camera>().enabled = true;
        Spieler.SetActive(true);
        GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
    }
}
