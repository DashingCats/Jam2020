using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class ItemImage : MonoBehaviour
{
    public Sprite cane, dog, headphones, pen, pencilcase, wallet, bike, laptop, textbook, carKeys;
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
            case 6:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = bike;
                break;
            case 7:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = laptop;
                break;
            case 8:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = textbook;
                break;
            case 9:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = carKeys;
                break;
        }
    }
    public void imgIncrease()
    {
        imgnum++;

        if (imgnum > 9)
            imgnum = 0;

        imgchange();
    }

    public void imgDecrease()
    {
        imgnum--;

        if (imgnum < 0)
            imgnum = 9;

        imgchange();
    }

}
