using UnityEngine;
using System.Collections;

public class Esmagar : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || (other.gameObject.CompareTag("tiro")))
        {
            Destroy(other.gameObject);

        }
    }
}
