using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasse : MonoBehaviour
{
    bool Outliness = false;
    public Camera main;

    // Start is called before the first frame update
    public void Start()
    {
        //GameObject.Find("Wim").GetComponent<Wim>().counter += 1;

        gameObject.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

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
            if (hit.collider.CompareTag("Cup"))
            {
                //GameObject.Find("Wim").GetComponent<Wim>().counter += 1;
                //Debug.Log(GameObject.Find("Wim").GetComponent<Wim>().counter);
                Destroy(gameObject);
            }
        }
    }
}