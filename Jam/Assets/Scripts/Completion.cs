using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Completion : MonoBehaviour
{
    public CharacterImage charfile;
    public ItemImage itemfile;
    public TextChange textbox;
    public float volume;

    public AudioSource correctsound;
    public AudioClip audio;

    // Start is called before the first frame update
    void Start()
    {
        charfile = GameObject.Find("Image").GetComponent<CharacterImage>();
        itemfile = GameObject.Find("Item").GetComponent<ItemImage>();
        textbox = GameObject.Find("Text").GetComponent<TextChange>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void submit()
    {
        if ((charfile.charnum == 0) && (itemfile.imgnum == 4))
        {
            //AudioSource.PlayClipAtPoint(correctsound, transform.position, volume);
            textbox.hints.text = "Ah thank you so much! I had to finish an art piece tonight";
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 1) && itemfile.imgnum == 3)
        {
            textbox.hints.text = "...Don't tell anyone this is mine okay? thanks.";
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 2) && itemfile.imgnum == 10)
        {
            textbox.hints.text = "Thank you so so so much! I couldn't bear be without him!!! ";
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 3) && itemfile.imgnum == 1)
        {
            textbox.hints.text = "Thanks man! Can't believe he'd run off like that.";
            textbox.thankyou();
            StartCoroutine(Correct());
        }
        else if ((charfile.charnum == 4) && itemfile.imgnum == 8)
        {
            textbox.hints.text = "Well i guess you saved me an extra $200, so thanks?";
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 5) && itemfile.imgnum == 6)
        {
            textbox.hints.text = "Thank you, I dont think i'd be able to go home without it!";
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 6) && itemfile.imgnum == 2)
        {
            textbox.hints.text = "You found them great! I really need those morning jams!";
            textbox.thankyou();
            StartCoroutine(Correct());
        }
        else if ((charfile.charnum == 7) && itemfile.imgnum == 12)
        {
            textbox.hints.text = "Thanks, really i needed my lunch.";
            textbox.thankyou();
            StartCoroutine(Correct());
            

        }
        else 
        {
            textbox.hints.text = "Um this does not belong to me!";
            textbox.thankyou();
            StartCoroutine(WaitNo());

        }
    }

    IEnumerator Correct()
    {
        yield return new WaitForSeconds(2);

        charfile.charnum++;

        if (charfile.charnum >= 12)
            charfile.charnum = 0;

        charfile.imgchange();
        textbox.textchange();
    }
    IEnumerator WaitNo()
    {
        yield return new WaitForSeconds(2);

        charfile.imgchange();
        textbox.textchange();
    }


}
