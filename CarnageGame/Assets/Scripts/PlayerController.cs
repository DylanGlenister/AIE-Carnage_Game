using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private enum PlayerNumber
    {
        PlayerOne = 1,
        PlayerTwo,
        PlayerThree,
        PlayerFour,
    }

    public bool m_bIsAlive;
    [SerializeField, Tooltip("Only used for controller input")]
    private PlayerNumber m_uiPlayerNo;

    public float m_fSpeed = 50f;

    private Rigidbody m_rbRigidbody;
    private GameObject m_goLookObj;
    private MultiTargetCamera m_mtcCamera;

    private void Start()
    {
        m_rbRigidbody = GetComponent<Rigidbody>();
        m_goLookObj = transform.GetChild(0).gameObject;
        m_mtcCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MultiTargetCamera>();

        m_bIsAlive = false;
    }
	
    private void Update()
    {
        if (!m_bIsAlive)
            return;

        // Player one controls
        if (m_uiPlayerNo == PlayerNumber.PlayerOne)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P1 LS Horizontal"),
                0, Input.GetAxis("P1 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Applies movement
            m_rbRigidbody.AddForce(Input.GetAxis("P1 LS Horizontal") * m_fSpeed * Time.deltaTime * 60, 0,
                Input.GetAxis("P1 LS Vertical") * m_fSpeed * Time.deltaTime * 60, ForceMode.Force);
        }
        // Player two controls
        if (m_uiPlayerNo == PlayerNumber.PlayerTwo)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P2 LS Horizontal"),
                0, Input.GetAxis("P2 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Applies movement
            m_rbRigidbody.AddForce(Input.GetAxis("P2 LS Horizontal") * m_fSpeed * Time.deltaTime * 60, 0,
                Input.GetAxis("P2 LS Vertical") * m_fSpeed * Time.deltaTime * 60, ForceMode.Force);
        }
        // Player three controls
        if (m_uiPlayerNo == PlayerNumber.PlayerThree)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P3 LS Horizontal"),
                0, Input.GetAxis("P3 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Applies movement
            m_rbRigidbody.AddForce(Input.GetAxis("P3 LS Horizontal") * m_fSpeed * Time.deltaTime * 60, 0,
                Input.GetAxis("P3 LS Vertical") * m_fSpeed * Time.deltaTime * 60, ForceMode.Force);
        }
        // Player four controls
        if (m_uiPlayerNo == PlayerNumber.PlayerFour)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P4 LS Horizontal"),
                0, Input.GetAxis("P4 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Applies movement
            m_rbRigidbody.AddForce(Input.GetAxis("P4 LS Horizontal") * m_fSpeed * Time.deltaTime * 60, 0,
                Input.GetAxis("P4 LS Vertical") * m_fSpeed * Time.deltaTime * 60, ForceMode.Force);
        }
    }

    private void FixedUpdate()
    {
        if (!m_bIsAlive)
            return;

        // If the player falls below y0 then they are pronounced dead
        if (transform.position.y < 0)
        {
            m_bIsAlive = false;
            if (m_mtcCamera.targets.Count > 0)
            {
                m_mtcCamera.targets.Remove(gameObject.transform);
            }
        }

        //// Player one controls
        //if (m_uiPlayerNo == PlayerNumber.PlayerOne)
        //{
        //    // Looking
        //    m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P1 LS Horizontal"),
        //        0, Input.GetAxis("P1 LS Vertical"));
        //    transform.LookAt(m_goLookObj.transform.position);

        //    // Applies movement
        //    m_rbRigidbody.AddForce(Input.GetAxis("P1 LS Horizontal") * m_fSpeed, 0,
        //        Input.GetAxis("P1 LS Vertical") * m_fSpeed, ForceMode.Force);
        //}
        //// Player two controls
        //if (m_uiPlayerNo == PlayerNumber.PlayerTwo)
        //{
        //    // Looking
        //    m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P2 LS Horizontal"),
        //        0, Input.GetAxis("P2 LS Vertical"));
        //    transform.LookAt(m_goLookObj.transform.position);

        //    // Applies movement
        //    m_rbRigidbody.AddForce(Input.GetAxis("P2 LS Horizontal") * m_fSpeed, 0,
        //        Input.GetAxis("P2 LS Vertical") * m_fSpeed, ForceMode.Force);
        //}
        //// Player three controls
        //if (m_uiPlayerNo == PlayerNumber.PlayerThree)
        //{
        //    // Looking
        //    m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P3 LS Horizontal"),
        //        0, Input.GetAxis("P3 LS Vertical"));
        //    transform.LookAt(m_goLookObj.transform.position);

        //    // Applies movement
        //    m_rbRigidbody.AddForce(Input.GetAxis("P3 LS Horizontal") * m_fSpeed, 0,
        //        Input.GetAxis("P3 LS Vertical") * m_fSpeed, ForceMode.Force);
        //}
        //// Player four controls
        //if (m_uiPlayerNo == PlayerNumber.PlayerFour)
        //{
        //    // Looking
        //    m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P4 LS Horizontal"),
        //        0, Input.GetAxis("P4 LS Vertical"));
        //    transform.LookAt(m_goLookObj.transform.position);

        //    // Applies movement
        //    m_rbRigidbody.AddForce(Input.GetAxis("P4 LS Horizontal") * m_fSpeed, 0,
        //        Input.GetAxis("P4 LS Vertical") * m_fSpeed, ForceMode.Force);
        //}
    }
}
