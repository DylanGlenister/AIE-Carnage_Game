using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postWwiseMusicEvent : MonoBehaviour {

    public AK.Wwise.Event SceneCloseEvent;

    public void postSceneCloseEvent()
    {
        SceneCloseEvent.Post(gameObject);
    }
}
