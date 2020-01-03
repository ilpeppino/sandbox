using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingCube : MonoBehaviour
{

    [SerializeField] Transform transformMovingCube;
    [SerializeField] float deltaXPos, deltaZPos = 1f;
    [SerializeField] float speed = 0.5f;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceFromTarget = transformMovingCube.position - transform.position;
        transform.Translate(distanceFromTarget * speed * Time.deltaTime);
    }
}
