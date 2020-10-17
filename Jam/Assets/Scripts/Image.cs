using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class Image : MonoBehaviour
{
    public Sprite cane, dog, headphones, pen, pencilcase, wallet;
    public int imgnum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cane;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void imgchange()
    {
        switch (imgnum)
        {
            case 0:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = cane;
                break;
            case 1:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = dog;
                break;
            case 2:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = headphones;
                break;
            case 3:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = pen;
                break;
            case 4:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = pencilcase;
                break;
            case 5:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = wallet;
                break;
        }
    }
    public void imgIncrease()
    {
        imgnum++;

        if (imgnum > 5)
            imgnum = 0;

        imgchange();
    }

    public void imgDecrease()
    {
        imgnum--;

        if (imgnum < 0)
            imgnum = 6;

        imgchange();
    }

}
