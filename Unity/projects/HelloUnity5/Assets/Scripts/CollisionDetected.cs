using UnityEngine;
using System.Collections;

public class CollisionDetected : MonoBehaviour {

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter.name=" + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay.name=" + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit.name=" + gameObject.name);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter.name=" + gameObject.name);
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay.name=" + gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit.name=" + gameObject.name);
    }
}
