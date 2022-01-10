using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wim : MonoBehaviour
{
    public Camera cam1;
    public Camera maincam;

    private float clicked = 0;
    private float clicktime = 0;
    private float clickdelay = 1f;
    private GameObject Spieler;
    private bool doppelklick = false;
    private bool Fertig = false;

    private bool Wimmelbild = false;

    private void Start()
    {
        Spieler = GameObject.Find("Spielfigur");

        gameObject.GetComponent<Outline>().enabled = false;
    }

    private void OnMouseDown()
    {
        clicked++;
        clicktime = Time.time;
        Debug.Log("ClickWim");
    }

    private void OnMouseEnter()
    {
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = true;
    }

    private void OnMouseExit()
    {
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = false;
    }

    private void Update()
    {
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            doppelklick = true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1)
        {
            clicked = 0;
            doppelklick = false;
        }

        if (doppelklick)
        {
            if (Fertig)
            {
                cam1.GetComponent<Camera>().enabled = false;
                maincam.GetComponent<Camera>().enabled = true;
                Spieler.SetActive(true);
                GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
            }

            doppelklick = false;
        }
    }
}