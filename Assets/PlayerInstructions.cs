using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInstructions : MonoBehaviour
{
    string Instructions = "I should clean the coffeetable";
    public Text PlayerInstructionsElement;
    bool TextChanged1 = false;
    bool TextChanged2 = false;

    void Start()
    {
        PlayerInstructionsElement.text = Instructions;
    }

    void Update()
    {
        if (GameObject.Find("ETObj") == null && TextChanged1 == false)
        {
            Instructions = "Whats that on my Desk?";
            PlayerInstructionsElement.text = Instructions;
            TextChanged1 = true;
        }
        if (GameObject.Find("ETObj2") == null && TextChanged2 == false)
        {
            Instructions = "Didnt I see a third newspaper in the shelf?";
            PlayerInstructionsElement.text = Instructions;
            TextChanged2 = true;
        }
    }
}
