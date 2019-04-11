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

    public GameObject m_goLvl1Btn;
    public GameObject m_goLvl2Btn;

    private void Start()
    {
        // Initialises the level buttons to be hidden
        m_goLvl1Btn.SetActive(false);
        m_goLvl2Btn.SetActive(false);
    }

    public void PlayBtnPress()
    {
        if (!m_bLevelSelectVisible)
        {
            // Offsets the play and quit button
            m_goPlayBtn.transform.position = m_goPlayBtn.transform.position + new Vector3(-m_fUIOffsetAmount * Screen.width, 0, 0);
            m_goQuitBtn.transform.position = m_goQuitBtn.transform.position + new Vector3(-m_fUIOffsetAmount * Screen.width, 0, 0);

            // Show the level selects
            m_goLvl1Btn.SetActive(true);
            m_goLvl2Btn.SetActive(true);

            m_bLevelSelectVisible = true;
        }
        else
        {
            // Offsets the play and quit button
            m_goPlayBtn.transform.position = m_goPlayBtn.transform.position + new Vector3(m_fUIOffsetAmount * Screen.width, 0, 0);
            m_goQuitBtn.transform.position = m_goQuitBtn.transform.position + new Vector3(m_fUIOffsetAmount * Screen.width, 0, 0);

            // Hide the level select
            m_goLvl1Btn.SetActive(false);
            m_goLvl2Btn.SetActive(false);

            m_bLevelSelectVisible = false;
        }
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
