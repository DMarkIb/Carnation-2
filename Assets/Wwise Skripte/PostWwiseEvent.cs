using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Schritt;
    public AK.Wwise.Event Voice;
    // Start is called before the first frame update
    void Start()
    {
        Voice.Post(gameObject);
        Debug.Log("Voiceline");
    }

    public void SchrittSound()
    {
        Schritt.Post(gameObject);
    }

}
