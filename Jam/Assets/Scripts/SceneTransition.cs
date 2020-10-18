using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeScenes(string scene)
    {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }
    public void final()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}
