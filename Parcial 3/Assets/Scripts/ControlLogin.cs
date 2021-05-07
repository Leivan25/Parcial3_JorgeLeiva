using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLogin : MonoBehaviour
{
    private bool complete;
    private bool complete2;
    private string input;
    private string input2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadInput(string s)
    {
        complete = true;
        input = s;
    }

    public void ReadInput2(string i)
    {
        complete2 = true;
        input2 = i;
    }


    public void LoadScene(string sceneName)
    {
        if(complete == true && complete2 == true)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.Log("Rellena todos los campos");
        }
        
    }
}
