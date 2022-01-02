using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOutlines : MonoBehaviour
{
    bool Outliness = false;
    public Camera cam1;


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
        Ray ray = cam1.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Boden"))
            {
                Debug.Log("U got Bodend");
            }
            else if (hit.collider.CompareTag("Messer"))
            {
                Debug.Log("U got Messered");
                //VOICELINE
            }
            else if (hit.collider.CompareTag("Pillen"))
            {
                Debug.Log("U got Pills");
                //VOICELINE
            }
            else if (hit.collider.CompareTag("Notebook"))
            {
                Debug.Log("U got read");
                //VOICELINE
            }
        }
    }
}
