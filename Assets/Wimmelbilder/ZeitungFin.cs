using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitungFin : MonoBehaviour
{
    public Camera paperCam;
    public Camera mainCam;
    public GameObject Spieler;

    private void OnMouseDown()
    {
        paperCam.GetComponent<Camera>().enabled = false;
        mainCam.GetComponent<Camera>().enabled = true;
        Spieler.SetActive(true);
        GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
    }
}