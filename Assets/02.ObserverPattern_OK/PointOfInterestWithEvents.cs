using System;
using UnityEngine;

public class PointOfInterestWithEvents : MonoBehaviour
{

    public static event Action<PointOfInterestWithEvents> OnPointOfInterestEntered;

    [SerializeField] string _poiName;

    public string PoiName { get { return _poiName; } }

    private void OnTriggerEnter(Collider other)
    {
        OnPointOfInterestEntered?.Invoke(this);
        
        /* The line above is extensively written as below 
          
        if (OnPointOfInterestEntered != null)
        {
            OnPointOfInterestEntered(this);
        }

        */
    }
}
