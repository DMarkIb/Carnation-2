using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VLOutlines : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
