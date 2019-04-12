using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postWwiseEvent : MonoBehaviour {

    public AK.Wwise.Event SelectMadeEvent;
    public AK.Wwise.Event BigSelectMadeEvent;
    public AK.Wwise.Event SelectMoveEvent;
    public AK.Wwise.Event SceneCloseEvent;

    public void postSelectMadeEvent()
    {
        SelectMadeEvent.Post(gameObject);
    }

    public void postBigSelectMadeEvent()
    {
        BigSelectMadeEvent.Post(gameObject);
    }

    public void postSelectMoveEvent()
    {
        SelectMoveEvent.Post(gameObject);
    }



}
