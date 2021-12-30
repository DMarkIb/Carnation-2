using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOutlines : MonoBehaviour
{
    bool Wimmelbild = false;

    // Start is called before the first frame update
    public void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseEnter()
    {
        Wimmelbild = true;
        if (Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        Wimmelbild = false;
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = false;
        
    }
}
