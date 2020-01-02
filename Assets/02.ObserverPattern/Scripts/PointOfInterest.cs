using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : Subject
{
    [SerializeField] private string pointOfInterestName;

    private void OnTriggerEnter(Collider collider)
    {
        Notify(pointOfInterestName, NotificationType.AchievementUnlocked);
    }

}
