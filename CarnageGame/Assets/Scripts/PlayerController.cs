using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool m_bActive;
    public uint m_uiPlayerNo = 0;

    public float m_fSpeed = 50f;

    public Rigidbody m_rbRigidbody;
    public GameObject m_goLookObj;
    
    void Start ()
    {
        m_rbRigidbody = GetComponent<Rigidbody>();
        m_bActive = false;

        if (m_uiPlayerNo > 3)
            m_uiPlayerNo = 3;
    }
	
	void FixedUpdate ()
    {
        if (!m_bActive)
            return;

        if (transform.position.y < -0.5f)
        {
            m_bActive = false;
        }

        // Player one controls
        if (m_uiPlayerNo == 0)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P1 LS Horizontal"), 0, Input.GetAxis("P1 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Horizontal movement
            m_rbRigidbody.AddForce(Input.GetAxis("P1 LS Horizontal") * m_fSpeed, 0, 0, ForceMode.Force);
            // Vertical movement
            m_rbRigidbody.AddForce(0, 0, Input.GetAxis("P1 LS Vertical") * m_fSpeed, ForceMode.Force);
        }
        // Player two controls
        if (m_uiPlayerNo == 1)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P2 LS Horizontal"), 0, Input.GetAxis("P2 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Horizontal movement
            m_rbRigidbody.AddForce(Input.GetAxis("P2 LS Horizontal") * m_fSpeed, 0, 0, ForceMode.Force);
            // Vertical movement
            m_rbRigidbody.AddForce(0, 0, Input.GetAxis("P2 LS Vertical") * m_fSpeed, ForceMode.Force);
        }
        // Player three controls
        if (m_uiPlayerNo == 2)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P3 LS Horizontal"), 0, Input.GetAxis("P3 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Horizontal movement
            m_rbRigidbody.AddForce(Input.GetAxis("P3 LS Horizontal") * m_fSpeed, 0, 0, ForceMode.Force);
            // Vertical movement
            m_rbRigidbody.AddForce(0, 0, Input.GetAxis("P3 LS Vertical") * m_fSpeed, ForceMode.Force);
        }
        // Player four controls
        if (m_uiPlayerNo == 3)
        {
            // Looking
            m_goLookObj.transform.position = transform.position + new Vector3(Input.GetAxis("P4 LS Horizontal"), 0, Input.GetAxis("P4 LS Vertical"));
            transform.LookAt(m_goLookObj.transform.position);

            // Horizontal movement
            m_rbRigidbody.AddForce(Input.GetAxis("P4 LS Horizontal") * m_fSpeed, 0, 0, ForceMode.Force);
            // Vertical movement
            m_rbRigidbody.AddForce(0, 0, Input.GetAxis("P4 LS Vertical") * m_fSpeed, ForceMode.Force);
        }
    }
}