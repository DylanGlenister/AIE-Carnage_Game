using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControls : MonoBehaviour {

    public string Level1Name;
    public string Level2Name;

    public void loadLevel(int number)
    {
        if (number == 1)
        {
            SceneManager.LoadScene(Level1Name);
        }
        else if (number == 2)
        {
            SceneManager.LoadScene(Level2Name);
        }
        else
        {
            Debug.Log("Invalid Scene Load Attempt");
        }
    }
}
