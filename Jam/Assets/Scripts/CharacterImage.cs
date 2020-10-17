using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class CharacterImage : MonoBehaviour
{
    public Sprite character1, character2, character3, character4, character5;
    public int charnum = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = character1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void imgchange()
    {
        switch (charnum)
        {
            case 0:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = character1;
                break;
            case 1:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = character2;
                break;
            case 2:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = character3;
                break;
            case 3:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = character4;
                break;
            case 4:
                this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = character5;
                break;
           
        }
    }

}
