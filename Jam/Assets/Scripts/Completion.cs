using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

using UnityEngine.SceneManagement;




public class Completion : MonoBehaviour
{
    public CharacterImage charfile;
    public ItemImage itemfile;
    public SceneTransition scenefile;

    public TextChange textbox;
    public TextChange finalScore;
    public float volume;

    public AudioSource audioSource;
    public AudioClip audioClip;


    public int points = 0;

    public static Completion instance = null;
    
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        charfile = GameObject.Find("Image").GetComponent<CharacterImage>();
        itemfile = GameObject.Find("Item").GetComponent<ItemImage>();
        textbox = GameObject.Find("Text").GetComponent<TextChange>();
        scenefile = GameObject.Find("SceneManager").GetComponent<SceneTransition>();


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void submit()
    {
        if ((charfile.charnum == 0) && (itemfile.imgnum == 4))
        {
            playClip();
            textbox.hints.text = "Ah thank you so much! I had to finish an art piece tonight";
            itemfile.bpencilcase = true;
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 1) && itemfile.imgnum == 3)
        {
            playClip();
            textbox.hints.text = "...Don't tell anyone this is mine okay? thanks.";
            itemfile.bpen = true;
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 2) && itemfile.imgnum == 10)
        {
            playClip();
            textbox.hints.text = "Thank you so so so much! I couldn't bear be without him!!! ";
            itemfile.bteddyBear = true;
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 3) && itemfile.imgnum == 1)
        {
            playClip();
            textbox.hints.text = "Thanks man! Can't believe he'd run off like that.";
            itemfile.bdog = true;
            textbox.thankyou();
            StartCoroutine(Correct());
        }
        else if ((charfile.charnum == 4) && itemfile.imgnum == 8)
        {
            playClip();
            textbox.hints.text = "Well i guess you saved me an extra $200, so thanks?";
            itemfile.btextbook = true;
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 5) && itemfile.imgnum == 6)
        {
            playClip();
            textbox.hints.text = "Thank you, I dont think i'd be able to go home without it!";
            itemfile.bbike = true;
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else if ((charfile.charnum == 6) && itemfile.imgnum == 2)
        {
            playClip();
            textbox.hints.text = "You found them great! I really need those morning jams!";
            itemfile.bheadphones = true;
            textbox.thankyou();
            StartCoroutine(Correct());
        }
        else if ((charfile.charnum == 7) && itemfile.imgnum == 12)
        {
            playClip();
            textbox.hints.text = "Thanks, really i needed my lunch.";
            itemfile.bsandwich = true;
            textbox.thankyou();
            StartCoroutine(Correct());

        }
        else 
        {
            textbox.hints.text = "This does not belong to me!";
            textbox.thankyou();
            StartCoroutine(WaitNo());

        }
    }


    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    IEnumerator Correct()
    {

        points += 100;


        yield return new WaitForSeconds(3);


        if (charfile.charnum == 7)
        {
            scenefile.final();
        }
        charfile.charnum++;

        charfile.imgchange();
        textbox.textchange();

        textbox.scoreChange(points);
    }
    IEnumerator WaitNo()
    {
        points -= 50;

        if (points < 0)
            points = 0;

        yield return new WaitForSeconds(2);

        charfile.imgchange();
        textbox.textchange();


        textbox.scoreChange(points);
    }



}
