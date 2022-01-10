using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public Camera Cam;
    public Transform From;
    public Transform To;

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
    //Wenn object angeklcikt wird, wird es "weg bewegt" und nach 2 sec automatisch gelöscht, aber nur objecte die den Tag haben auch zerstört zu werden
    public void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Destroy"))
            {
                transform.position = Vector3.Lerp(From.position, To.position, 0.3f);
                StartCoroutine(waiterD());
            }
        }
    }

    private IEnumerator waiterD()
    {
        yield return new WaitForSecondsRealtime(2);
        Destroy(gameObject);
    }
}
