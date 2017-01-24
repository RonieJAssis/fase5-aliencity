﻿using UnityEngine;
using System.Collections;

public class Cairespinhos1 : MonoBehaviour
{

    private Rigidbody rb;
    Vector3 v3;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;


    }

    // Update is called once per frame
    void Update()
    {

    }
  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || (other.gameObject.CompareTag("tiro")))
        {
            {
                rb.useGravity = true;
                v3 = rb.velocity;
                v3.y = -15.0f;
                rb.velocity = v3;


            }
        }
    }
}
