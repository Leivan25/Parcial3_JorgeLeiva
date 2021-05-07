using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cf2 : MonoBehaviour
{
    private bool complete;
    private bool complete2;
    private string input;
    private string input2;
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
        input = s;
        complete = true;
    }

    public void ReadInput2(string i)
    {
        if (Input.GetKeyDown("return"))
        {
            input2 = i;
            complete2 = true;
            label.SetActive(true);
            label2.SetActive(false);
        }
    }


    public void LoadScene(string sceneName)
    {
        if (complete == true && complete2 == true)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            label2.SetActive(true);
        }

    }
}
