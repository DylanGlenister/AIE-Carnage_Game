using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    private bool m_bRaceOn;
    public Text m_txtUiText;
    public GameManager m_gmGameManager;

    private void Start ()
    {
        m_bRaceOn = true;
    }

    public void OnTriggerEnter (Collider other)
    {
        if (!m_bRaceOn)
            return;

        // Player one wins
        if (other.gameObject.tag == "PlayerOne")
        {
            m_bRaceOn = false;
            m_txtUiText.enabled = true;
            m_txtUiText.text = "Player One Wins!";
            m_gmGameManager.m_bGameOver = true;
        }
        
        // Player two wins
        if (other.gameObject.tag == "PlayerTwo")
        {
            m_bRaceOn = false;
            m_txtUiText.enabled = true;
            m_txtUiText.text = "Player Two Wins!";
            m_gmGameManager.m_bGameOver = true;
        }
        
        // Player three wins
        if (other.gameObject.tag == "PlayerThree")
        {
            m_bRaceOn = false;
            m_txtUiText.enabled = true;
            m_txtUiText.text = "Player Three Wins!";
            m_gmGameManager.m_bGameOver = true;
        }
        
        // Player four wins
        if (other.gameObject.tag == "PlayerFour")
        {
            m_bRaceOn = false;
            m_txtUiText.enabled = true;
            m_txtUiText.text = "Player Four Wins!";
            m_gmGameManager.m_bGameOver = true;
        }
    }
}
