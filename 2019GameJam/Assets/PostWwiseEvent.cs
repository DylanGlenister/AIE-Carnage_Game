using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{

    public AK.Wwise.Event myEvent;

    public void postEvent()
    {
        myEvent.Post(gameObject);
    }
};
