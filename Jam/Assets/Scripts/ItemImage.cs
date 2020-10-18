using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class ItemImage : MonoBehaviour
{
    public Sprite cane, dog, headphones, pen, pencilcase, wallet, bike, laptop, textbook, carKeys, teddyBear, groceryBag, sandwich;
    public bool bcane, bdog, bheadphones, bpen, bpencilcase, bwallet, bbike, blaptop, btextbook, bcarkeys, bteddyBear, bgroceryBag, bsandwich = false;
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
            case 10:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = teddyBear;
                break;
            case 11:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = groceryBag;
                break;
            case 12:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sandwich;
                break;
        }
    }
    public void imgIncrease()
    {
        imgnum++;

        if (imgnum > 12)
            imgnum = 0;

        int i = 0;
        while (i < 12)
        {
            if ((bpencilcase == true) && (imgnum == 4))
                imgnum++;
            if ((bpen == true) && (imgnum == 3))
                imgnum++;
            if ((bteddyBear == true) && (imgnum == 10))
                imgnum++;
            if ((bdog == true) && (imgnum == 1))
                imgnum++;
            if ((btextbook == true) && (imgnum == 8))
                imgnum++;
            if ((bbike == true) && (imgnum == 6))
                imgnum++;
            if ((bheadphones == true) && (imgnum == 2))
                imgnum++;
            if ((bsandwich == true) && (imgnum == 12))
                imgnum++;

            i++;
        }

        imgchange();
    }

    public void imgDecrease()
    {
        imgnum--;

        if (imgnum < 0)
            imgnum = 12;

        int i = 0;
        while (i < 12)
        {
            if ((bpencilcase == true) && (imgnum == 4))
                imgnum--;
            if ((bpen == true) && (imgnum == 3))
                imgnum--;
            if ((bteddyBear == true) && (imgnum == 10))
                imgnum--;
            if ((bdog == true) && (imgnum == 1))
                imgnum--;
            if ((btextbook == true) && (imgnum == 8))
                imgnum--;
            if ((bbike == true) && (imgnum == 6))
                imgnum--;
            if ((bheadphones == true) && (imgnum == 2))
                imgnum--;
            if ((bsandwich == true) && (imgnum == 12))
                imgnum--;

            i++;
        }
        imgchange();
    }

}
