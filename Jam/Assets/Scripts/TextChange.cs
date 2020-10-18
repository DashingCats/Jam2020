using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public CharacterImage charfile;
    public Text hints;

    // Start is called before the first frame update
    void Start()
    {
        charfile = GameObject.Find("Image").GetComponent<CharacterImage>();
        
        hints = gameObject.GetComponent<Text>();
        hints.text = "Its where i store my favourite things!\n";
    }

    // Update is called once per frame
    void Update()
    {
        


  
        
    }

    public void thankyou()
    {
        hints = this.GetComponent<Text>();
    }

   public void textchange()
    {
        if (charfile.charnum == 0)
        {
            hints.text = "Its where i store my favourite things!\n";
        }
        if (charfile.charnum == 1)
        {
            hints.text = "Its totally not cute and pink!! Seriously.\n";
        }
        if (charfile.charnum == 2)
        {
            hints.text = "Its the best thing in the world!Its so soft and cuddly!\n";
        }
        if (charfile.charnum == 3)
        {
            hints.text = "I can never leave home without him\n";
        }
        if (charfile.charnum == 4)
        {
            hints.text = "My backpack has been feeling lighter these days \n\nLooking at it gives me nightmares";
        }
        if (charfile.charnum == 5)
        {
            hints.text = "I'm not one for excercise, but its a great alternative to getting around.\n";
        }
        if (charfile.charnum == 6)
        {
            hints.text = "I just got them! They seem to always break after a week though\n";
        }
        if (charfile.charnum == 7)
        {
            hints.text = "I made it myself! I think half of its gone though...";
        }
    }
    
}
