using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool Outliness = false;
    public Camera main;

    public void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    public void OnMouseEnter()
    {
        Outliness = true;
        if (Outliness)
            gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
        Outliness = false;
        if (!Outliness)
            gameObject.GetComponent<Outline>().enabled = false;
    }

    public void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Door"))
            {
                Debug.Log("U got Exited");
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
