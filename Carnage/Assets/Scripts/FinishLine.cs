using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {

    //public Rigidbody rigid;
    public Image image;
    public Text text;
    private bool isActive;

    private void Start()
    {
        image.enabled = false;
        text.enabled = false;
        isActive = false;
    }


    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if(other.gameObject.tag == "Player")
        {
            image.enabled = true;
            text.enabled = true;
            isActive = true;
        }
    }
}
