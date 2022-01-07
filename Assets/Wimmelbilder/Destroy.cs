using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public Camera Cam;
    public Transform From;
    public Transform To;

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
        Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Destroy"))
            {
                transform.position = Vector3.Lerp(From.position, To.position, 0.3f);
                StartCoroutine(waiterD());
                //Destroy(gameObject);
            }
        }
    }

    IEnumerator waiterD()
    {
        yield return new WaitForSecondsRealtime(3);
        Destroy(gameObject);
    }
}
