using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoomPapers : MonoBehaviour
{
    private bool Active = false;
    public Transform von;
    public Transform bis;
    public Camera mainCam;
    public Camera paperCam;
    public GameObject Spieler;

    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {
        if (GameObject.Find("ETObj") == null && Active == false)
        {
            transform.position = Vector3.Lerp(von.position, bis.position, 1.0f);
            Active = true;
        }
    }

    public void OnMouseEnter()
    {
        if (GameObject.Find("ETObj") == null)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    public void OnMouseExit()
    {
        if (GameObject.Find("ETObj") == null)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }

    public void OnMouseDown()
    {
        paperCam.GetComponent<Camera>().enabled = true;
        mainCam.GetComponent<Camera>().enabled = false;
        Spieler.SetActive(false);
    }
}