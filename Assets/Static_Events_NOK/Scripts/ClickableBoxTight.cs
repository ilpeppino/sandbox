using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableBoxTight : MonoBehaviour
{

    private ParticleControllerTight particleController;
    private Collider collider;

    private void Awake()
    {
        collider = GetComponent<Collider>();
        particleController = FindObjectOfType<ParticleControllerTight>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (collider.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                particleController.SpawnParticleOnBox(this);
                Debug.Log("Hit box " + collider.gameObject.name);
            }
        }
    }
}