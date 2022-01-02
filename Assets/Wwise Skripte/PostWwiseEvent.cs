using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Schritt;

    // Start is called before the first frame update
    void Start()
    {
        //Voice_Knife.Post(gameObject);

    }

    public void SchrittSound()
    {
        Schritt.Post(gameObject);
    }


}
