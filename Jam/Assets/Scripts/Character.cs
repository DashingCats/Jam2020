using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int charTag;
    private string charName;

    public int GetTag()
    {
        return charTag;
    }

    public void SetTag(int i)
    {
        charTag = i;
    }

    public string GetName()
    {
        return charName;
    }

    public void SetName(string s)
    {
        charName = s;
    }
}
