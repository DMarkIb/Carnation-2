using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasse : MonoBehaviour
{
    public Camera CT;

    public void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

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

    public void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = CT.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Destroy"))
            {
                GameObject.Find("Tassen").GetComponent<Tassen>().counter += 1;
                Destroy(gameObject);
            }
        }
    }
}