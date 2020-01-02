using UnityEngine;

public class AchievementSystem : Observer
{

    private void Start()
    {
        PlayerPrefs.DeleteAll();

        // this piece can be included in the object spawner 
        foreach (var pointOfInterest in FindObjectsOfType<PointOfInterest>())
        {
            // each Subject poi registers the observer AchievementSystem
            pointOfInterest.RegisterObserver(this);
        }
    }

    // OnNotify was defined as Abstract in the Observer. Since this class is a subclass of Observer, it has to override that abstract method
    // Subject will notify all the observers registered on the OnNotify with the type of notification and its value. 
    public override void OnNotify(object value, NotificationType notificationType)
    {
        if (notificationType == NotificationType.AchievementUnlocked)
        {
            string achievementKey = "Achievement-" + value;

            if (PlayerPrefs.GetInt(achievementKey) == 1)
                return;

            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log("Unlocked " + value);
        }
    }

}
public enum NotificationType
{
    AchievementUnlocked
}
