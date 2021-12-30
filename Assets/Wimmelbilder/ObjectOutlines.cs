using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOutlines : MonoBehaviour
{
    bool Outlines = false;

    // Start is called before the first frame update
    public void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Das hier ist ein Kommentar von Ronja
    }

    public void OnMouseEnter()
    {
        Outlines = true;
        if (Outlines)
            gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        Outlines = false;
        if (!Outlines)
            gameObject.GetComponent<Outline>().enabled = false;
    }
}
