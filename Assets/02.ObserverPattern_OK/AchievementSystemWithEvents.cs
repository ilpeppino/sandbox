using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystemWithEvents : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.DeleteAll();

        // This observer register on the event OnPointOfInterestEntered and execute its own method
        PointOfInterestWithEvents.OnPointOfInterestEntered += PointOfInterestWithEvents_OnPointOfInterestEntered;
    }

    private void PointOfInterestWithEvents_OnPointOfInterestEntered(PointOfInterestWithEvents pointOfInterest)
    {
        string achievementKey = "Achievement-" + pointOfInterest.PoiName;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
            return;

        PlayerPrefs.SetInt(achievementKey, 1);
        Debug.Log("Unlocked " + pointOfInterest.PoiName);
    }


    // Update is called once per frame
    private void OnDestroy()
    {
        PointOfInterestWithEvents.OnPointOfInterestEntered -= PointOfInterestWithEvents_OnPointOfInterestEntered;
    }
}
