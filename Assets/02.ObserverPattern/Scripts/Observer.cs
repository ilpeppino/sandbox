using System.Collections.Generic;
using UnityEngine;

// Observers need to implement the OnNotify method
public abstract class Observer : MonoBehaviour
{
    public abstract void OnNotify(object value, NotificationType notificationType);

}

// Subject is the class being observed by Observers
public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = new List<Observer>();

    // New observers (during spawn) have to register as an Observer
    public void RegisterObserver (Observer observer)
    {
        _observers.Add(observer);
    }

    // When something happens, Subject will notify all the observers with the type of notification and its value
    public void Notify(object value, NotificationType notificationType)
    {
        foreach(var observer in _observers)
        {
            observer.OnNotify(value, notificationType);
        }
    }
}
