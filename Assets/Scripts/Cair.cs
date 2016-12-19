using UnityEngine;
using System.Collections;

public class Cair: MonoBehaviour {

    public float fallDelay = 1f;


    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || (other.gameObject.CompareTag("tiro")))
        {
            {
                Invoke("Fall", fallDelay);
            }
        }
    }

    void Fall()
    {
        rb.isKinematic = false;
    }



}