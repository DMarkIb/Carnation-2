using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRPEsstisch : MonoBehaviour
{
    public Transform von;
    public Transform bis;
    private bool Active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ETObj") == null && Active == false)
        {
            transform.position = Vector3.Lerp(von.position, bis.position, 1.0f);
            Active = true;
        }
    }
}
