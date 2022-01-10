using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitungFin2 : MonoBehaviour
{
    public Camera paper2Cam;
    public Camera mainCam;
    public GameObject Spieler;

    private void OnMouseDown()
    {
        Debug.Log("Cam Switch");
        paper2Cam.GetComponent<Camera>().enabled = false;
        mainCam.GetComponent<Camera>().enabled = true;
        Spieler.SetActive(true);
        GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
    }
}
