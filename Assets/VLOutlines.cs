using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VLOutlines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
