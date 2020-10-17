using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Item : MonoBehaviour
{
    private int itemTag;
    private string itemName;


    public int GetTag()
    {
        return itemTag;
    }

    public void SetTag(int i)
    {
        itemTag = i;
    }

    public string GetName()
    {
        return itemName;
    }

    public void SetName(string s)
    {
        itemName = s;
    }

}