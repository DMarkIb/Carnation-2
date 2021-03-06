using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRP2 : MonoBehaviour
{
    private bool Active = false;
    public Transform von;
    public Transform bis;
    public Camera mainCam;
    public Camera paperCam;
    public GameObject Spieler;

    private void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    private void Update()
    {
        if (GameObject.Find("ETObj2") == null && Active == false)
        {
            transform.position = Vector3.Lerp(von.position, bis.position, 1.0f);
            Active = true;
        }
    }

    private void OnMouseEnter()
    {
        if (GameObject.Find("ETObj2") == null)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    private void OnMouseExit()
    {
        if (GameObject.Find("ETObj2") == null)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        paperCam.GetComponent<Camera>().enabled = true;
        mainCam.GetComponent<Camera>().enabled = false;
        Spieler.SetActive(false);
    }
}