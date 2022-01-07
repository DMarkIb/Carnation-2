using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInstructions : MonoBehaviour
{
    string Instructions = "I should clean the coffeetable"; //Starting Instructions
    public Text PlayerInstructionsElement;
    bool TextChanged1 = false;
    bool TextChanged2 = false;
    bool TextChanged3 = false;

    void Start()
    {
        PlayerInstructionsElement.text = Instructions; //Set Starting Instructions
    }

    void Update()
    {
        if (GameObject.Find("ETObj") == null && TextChanged1 == false) //if erstes WM erledigt, nächste Instruction
        {
            Instructions = "Whats that on my Desk?";
            PlayerInstructionsElement.text = Instructions;
            TextChanged1 = true;
        }
        if (GameObject.Find("ETObj") == null && GameObject.Find("ETObj2") == null && TextChanged2 == false) //If Esstisch und Coffeetable WM erldigt, letzte Instruction
        {
            Instructions = "Didnt I see a third newspaper in the shelf?";
            PlayerInstructionsElement.text = Instructions;
            TextChanged2 = true;
        }
        if (GameObject.Find("ETObj") == null && GameObject.Find("ETObj2") == null && GameObject.Find("ETObj3") == null && TextChanged3 == false) //If alle Wms erledigt, Letzter Text
        {
            Instructions = "So thats what happened. But is it really my fault?";
            PlayerInstructionsElement.text = Instructions;
            TextChanged3 = true;
        }
    }
}
