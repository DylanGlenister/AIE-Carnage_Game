using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutTransition : MonoBehaviour {

    public GameObject SceneMusicControls;
    public Canvas blackScreen;
    float transitionTime = 1.5f;
    bool FadingIn = true;
    bool FadingOut = false;
    float timer = 0;

    void Start()
    {
        
    }

    void update()
    {
        if (FadingOut)
        {

        }
        else if (FadingIn)
        {
            blackScreen.
            blackScreen. = new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0);
        }
        else
        {
            timer = 0;
        }
    }
}
