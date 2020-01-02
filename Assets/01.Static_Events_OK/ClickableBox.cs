using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableBox : MonoBehaviour
{
    // Declare a static event (no instantiation needed on ClickableBox class)
    public static event Action<ClickableBox> OnAnyBoxClicked = delegate { };

    private Collider collider;

    private void Awake()
    {
        collider = GetComponent<Collider>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (collider.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                // The event is invoked by passing the box
                OnAnyBoxClicked(this);
                Debug.Log("Hit box " + collider.gameObject.name);
            }
        }
    }
}
