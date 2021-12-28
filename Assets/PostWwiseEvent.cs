using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event TestEvent;
    // Start is called before the first frame update
    void Start()
    {
        TestEvent.Post(gameObject);    
    }

}
