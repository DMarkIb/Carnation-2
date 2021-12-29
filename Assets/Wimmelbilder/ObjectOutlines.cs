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
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        if (!Wimmelbild)
            gameObject.GetComponent<Outline>().enabled = false;
    }
}
