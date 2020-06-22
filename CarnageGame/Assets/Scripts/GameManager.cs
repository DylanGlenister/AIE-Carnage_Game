using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool m_bActive;
    public bool m_bGameOver;
    public float m_fTimer;
    public Text m_tCountdownTxt;

    public PlayerController[] m_goPlayers;
    
	void Start ()
    {
        m_bGameOver = false;
        m_bActive = false;
        m_fTimer = 0;

        m_goPlayers = new PlayerController[4];
        m_goPlayers[0] = GameObject.FindGameObjectWithTag("PlayerOne").GetComponent<PlayerController>();
        m_goPlayers[1] = GameObject.FindGameObjectWithTag("PlayerTwo").GetComponent<PlayerController>();
        m_goPlayers[2] = GameObject.FindGameObjectWithTag("PlayerThree").GetComponent<PlayerController>();
        m_goPlayers[3] = GameObject.FindGameObjectWithTag("PlayerFour").GetComponent<PlayerController>();

        m_tCountdownTxt = transform.GetChild(0).gameObject.GetComponent<Text>();
        m_tCountdownTxt.enabled = false;

        for (int i = 0; i < m_goPlayers.Length; i++)
        {
            m_goPlayers[i].GetComponent<PlayerController>().m_bActive = false;
        }
    }
	
	void Update ()
    {
        m_fTimer += Time.deltaTime;
        if(m_bActive == false)
        {
            CountDown();
        }

        if (m_bGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
	}

    public void CountDown()
    {
        if(m_fTimer >= 1)
        {
            m_tCountdownTxt.text = "3";
            m_tCountdownTxt.enabled = true;

            if (m_fTimer >= 2)
            {
                m_tCountdownTxt.text = "2";

                if (m_fTimer >= 3)
                {
                    m_tCountdownTxt.text = "1";

                    if (m_fTimer >= 4)
                    {
                        m_tCountdownTxt.text = "Go!";
                        for (int i = 0; i < m_goPlayers.Length; i++)
                        {
                            m_goPlayers[i].GetComponent<PlayerController>().m_bActive = true;
                        }

                        if (m_fTimer >= 5)
                        {
                            m_tCountdownTxt.enabled = false;
                            m_bActive = true;
                        }
                    }
                }
            }
        }
    }
}