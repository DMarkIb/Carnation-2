using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsstischWM : MonoBehaviour
{
    public Camera ET;

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
        Ray ray = ET.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Destroy"))
            {
                GameObject.Find("ETWMOver").GetComponent<ETWMOver>().counter2 += 1;
                Destroy(gameObject);
            }
        }
    }
}
