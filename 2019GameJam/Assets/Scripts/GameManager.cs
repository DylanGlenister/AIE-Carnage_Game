using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float timer;
    private bool isActive;
    public Text[] text_UI;
  

	// Use this for initialization
	void Start () {
        isActive = false;
        timer = 0;

       for(int i = 0; i < text_UI.Length; i++)
        {
            text_UI[i].enabled = false;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(isActive == false)
        {
            CountDown();
        }
	}

    public void CountDown()
    {
        if(timer >= 1)
        {
            text_UI[0].enabled = true;

            if (timer >= 2)
            {
                text_UI[0].enabled = false;
                text_UI[1].enabled = true;

                if (timer >= 3)
                {
                    text_UI[1].enabled = false;
                    text_UI[2].enabled = true;

                    if (timer >= 4)
                    {
                        text_UI[2].enabled = false;
                        text_UI[3].enabled = true;

                        isActive = true;
                    }
                }
            }
        }
    }
}