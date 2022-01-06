using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wim : MonoBehaviour
{
    public Camera cam1;
    public Camera maincam;

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 1f;
    private GameObject Spieler;
    bool doppelklick = false;
    bool Fertig = false;

    bool Wimmelbild = false;

    public int counter;

    void Start()
    {
        Spieler = GameObject.Find("Spielfigur");

        gameObject.GetComponent<Outline>().enabled = false;
    }

    public void OnMouseDown()
    {
        clicked++;
        clicktime = Time.time;
        Debug.Log("ClickWim");
        //if (Fertig)
        //{
        //    cam1.GetComponent<Camera>().enabled = false;
        //    maincam.GetComponent<Camera>().enabled = true;
        //    Spieler.SetActive(true);
        //    GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = true;
        //}
    }

    public void OnMouseEnter()
    {
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = true;
    }
    
    public void OnMouseExit()
    {
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = false;
    }

    void Update()
    {
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            Debug.Log("Boob");
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