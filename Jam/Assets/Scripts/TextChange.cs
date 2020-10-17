using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public CharacterImage charfile;
    private Text hints;

    // Start is called before the first frame update
    void Start()
    {
        charfile = GameObject.Find("Image").GetComponent<CharacterImage>();
        hints = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (charfile.charnum == 0)
        {
            hints.text = "- Likes Cute Things\n";
        }
        if (charfile.charnum == 1)
        {
            hints.text = "- Likes Cute Things\n";
        }
        if (charfile.charnum == 2)
        {
            hints.text = "- Likes Cute Things\n";
        }
        if (charfile.charnum == 3)
        {
            hints.text = "- Likes Cute Things\n";
        }
        if (charfile.charnum == 4)
        {
            hints.text = "- Likes Cute Things\n";
        }


        hints = this.GetComponent<Text>();
        
    }

    
}
