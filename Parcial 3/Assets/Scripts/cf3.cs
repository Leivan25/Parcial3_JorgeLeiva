using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cf3 : MonoBehaviour
{
    private bool complete;
    private string input;

    public GameObject label;
    public GameObject label2;
    

    // Start is called before the first frame update
    void Start()
    {
        label.SetActive(false);
        label2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadInput(string s)
    {
        if (Input.GetKeyDown("return"))
        {
            input = s;
            complete = true;
            label.SetActive(true);
            label2.SetActive(false);
        }
    }



    public void LoadScene(string sceneName)
    {
        if (complete == true )
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            label2.SetActive(true);
        }

    }
}
