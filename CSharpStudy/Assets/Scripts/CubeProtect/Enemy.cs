using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 2;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 offset = transform.forward * Time.fixedDeltaTime * speed;
        rb.MovePosition(transform.position + offset);
    }
}
