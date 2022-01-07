using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit : MonoBehaviour
{
    public Camera ExitCam;
    public Camera maincam;
    public GameObject Spieler;
    bool switched = false;
    // Start is called before the first frame update
    void Start()
    {
        ExitCam.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (GameObject.Find("ETObj") == null && GameObject.Find("ETObj2") == null && GameObject.Find("ETObj3") == null && switched == false)
        {
            CameraSwitch();
        }
    }

    private void CameraSwitch()
    {
        ExitCam.GetComponent<Camera>().enabled = true;
        maincam.GetComponent<Camera>().enabled = false;
        GameObject.Find("Spielfigur").GetComponent<Spielfigur>().enabled = false;
        switched = true;
    }
}
