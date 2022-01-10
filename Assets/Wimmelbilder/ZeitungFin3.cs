using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitungFin3 : MonoBehaviour
{
    public Camera paper3Cam;
    public Camera mainCam;
    public GameObject Spieler;

    private void OnMouseDown()
    {
        Debug.Log("Cam Switch");
        paper3Cam.GetComponent<Camera>().enabled = false;
        mainCam.GetComponent<Camera>().enabled = true;
        Spieler.SetActive(true);
        GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
    }
}
