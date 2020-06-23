using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private bool m_bLevelSelectVisible = false;
    public float m_fUIOffsetAmount;

    public GameObject m_goPlayBtn;
    public GameObject m_goQuitBtn;
    public GameObject m_goLvlBtns;

    private void Start()
    {
        m_goPlayBtn = transform.GetChild(1).gameObject;
        m_goQuitBtn = transform.GetChild(2).gameObject;
        m_goLvlBtns = transform.GetChild(3).gameObject;

        // Initialises the level buttons to be hidden
        m_goLvlBtns.SetActive(false);
    }

    public void PlayBtnPress()
    {
        if (!m_bLevelSelectVisible)
        {
            // Offsets the play and quit button
            m_goPlayBtn.transform.position = m_goPlayBtn.transform.position + new Vector3(-m_fUIOffsetAmount * Screen.width, 0, 0);
            m_goQuitBtn.transform.position = m_goQuitBtn.transform.position + new Vector3(-m_fUIOffsetAmount * Screen.width, 0, 0);

            // Show the level selects
            m_goLvlBtns.SetActive(true);

            m_bLevelSelectVisible = true;
        }
        else
        {
            // Offsets the play and quit button
            m_goPlayBtn.transform.position = m_goPlayBtn.transform.position + new Vector3(m_fUIOffsetAmount * Screen.width, 0, 0);
            m_goQuitBtn.transform.position = m_goQuitBtn.transform.position + new Vector3(m_fUIOffsetAmount * Screen.width, 0, 0);

            // Hide the level select
            m_goLvlBtns.SetActive(false);

            m_bLevelSelectVisible = false;
        }
    }

    public void Lvl1BtnPress()
    {
        SceneManager.LoadScene(1);
    }

    public void Lvl2BtnPress()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitBtnPress()
    {
        // Exits either the unity editor or the standalone
#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
