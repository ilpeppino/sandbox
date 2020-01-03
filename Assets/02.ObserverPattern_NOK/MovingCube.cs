using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    [SerializeField] public float speed = 10f;
    [SerializeField] public float force = 200f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Mode 1: position
        // transform.position += Vector3.forward * speed * Time.deltaTime;

        // Mode 2: translate
        // transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        // Mode 3: add force
        // rb.AddForce(transform.forward * force * Time.deltaTime);

        // Mode 4: move position
        // rb.MovePosition(transform.position + (transform.forward * Time.deltaTime));

        // Mode 5: velocity
        // rb.velocity = transform.forward * Time.deltaTime * force;

        // Mode 6
        Vector3 input = new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.position += moveAmount;
        
    }
}

