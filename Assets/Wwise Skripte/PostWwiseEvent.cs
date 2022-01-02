using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Schritt;
    public AK.Wwise.Event Voice_Knife;
    // Start is called before the first frame update
    void Start()
    {
        Voice_Knife.Post(gameObject);
        Debug.Log("Voiceline");
    }

    public void SchrittSound()
    {
        Schritt.Post(gameObject);
    }

    public void Voiceline_Knife()
    {
        Voice_Knife.Post(gameObject);
    }
}
