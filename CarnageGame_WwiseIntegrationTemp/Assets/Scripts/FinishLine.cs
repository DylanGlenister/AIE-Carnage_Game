using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public Text text;
    private bool isActive;

    private void Start()
    {
        text.enabled = false;
        isActive = false;
    }


    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if(other.gameObject.tag == "Player")
        {
            text.enabled = true;
            isActive = true;
        }
    }
}
