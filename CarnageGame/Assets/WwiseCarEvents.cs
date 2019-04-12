using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseCarEvents : MonoBehaviour {

    public AK.Wwise.Event CarCollision;
    public AK.Wwise.Event RaceFinished;

    public void postCarCollisionEvent()
    {
        CarCollision.Post(gameObject);
    }

    public void raceFinishedEvent()
    {
        RaceFinished.Post(gameObject);
    }
}
