using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Completion completionfile;
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        Completion c = Completion.instance;

        score = gameObject.GetComponent<Text>();

        if (score != null)
            score.text = "Final Score: " + c.points + "\nMade By Rainbow Cat";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
