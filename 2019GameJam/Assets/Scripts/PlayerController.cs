using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool m_bActive;

    public float m_fSpeed = 10f;

    public Rigidbody m_rbRigidbody;
    public GameObject m_goLookObj;
    
    void Start ()
    {
        m_rbRigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        // Movement
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        m_goLookObj.transform.position = transform.position + new Vector3(horizontal, 0, vertical);

        // Horizontal movement
        m_rbRigidbody.AddForce(horizontal * m_fSpeed, 0, 0, ForceMode.Force);
        // Vertical movement
        m_rbRigidbody.AddForce(0, 0, vertical * m_fSpeed, ForceMode.Force);

        transform.LookAt(m_goLookObj.transform.position);
    }
}
