using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Camera cam1;
    public Camera maincam;
    public Animator Player;

    private float clicked = 0;
    private float clicktime = 0;
 
    private GameObject Spieler;
    private bool doppelklick = false;
    private bool Wimmelbild = false;

    private void Start()
    {
        Spieler = GameObject.Find("Spielfigur");
        cam1.GetComponent<Camera>().enabled = false;
        maincam.GetComponent<Camera>().enabled = true;
        gameObject.GetComponent<Outline>().enabled = false;
    }

    private void OnMouseDown()
    {
        clicked++;
        clicktime = Time.time;
    }

    private void OnMouseEnter()
    {
        if(!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = true;
    }

    private void OnMouseExit()
    {
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = false;
    }

    private void Update()
    {
        if (clicked > 2 || Time.time - clicktime > 1)
        {
            clicked = 0;
            doppelklick = false;
        }
        else if (clicked > 1 )
        {
            clicked = 0;
            clicktime = 0;
            //Debug.Log("Double");
            doppelklick = true;
        }
        
        if (doppelklick)
        {
            if (Vector3.Distance(Spieler.transform.position, transform.position) <= 1f && !Wimmelbild)
            {
                Player.SetBool("Interaction", true);
                GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = false;
                gameObject.GetComponent<Outline>().enabled = false;
        
                StartCoroutine(waiter());
            }
        
            doppelklick = false;
        }
    }
    private IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(2);
        //Debug.Log("Interaction");
        cam1.GetComponent<Camera>().enabled = true;
        maincam.GetComponent<Camera>().enabled = false; 
        Spieler.SetActive(false);
        Wimmelbild = true;
        Player.SetBool("Interaction", false);
    }
}
