using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOutlines : MonoBehaviour
{

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
            gameObject.GetComponent<Outline>().enabled = true;
    }

    public void OnMouseExit()
    {
            gameObject.GetComponent<Outline>().enabled = false;
    }

    //public void OnMouseDown()
    //{
    //    RaycastHit hit;
    //    Ray ray = cam1.ScreenPointToRay(Input.mousePosition);
    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        if (hit.collider.CompareTag("Boden"))
    //        {
    //            Debug.Log("U got Bodend");
    //        }
    //        else if (hit.collider.CompareTag("Messer"))
    //        {
    //            Debug.Log("U got Messered");
    //            //VOICELINE
    //        }
    //        else if (hit.collider.CompareTag("Pillen"))
    //        {
    //            Debug.Log("U got Pills");
    //            //VOICELINE
    //        }
    //        else if (hit.collider.CompareTag("Notebook"))
    //        {
    //            Debug.Log("U got read");
    //            //VOICELINE
    //        }
    //        else if (hit.collider.CompareTag("Destroy"))
    //        {
    //            Destroy(gameObject);
    //        }
    //    }
    //}
}
