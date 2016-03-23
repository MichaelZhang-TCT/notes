using UnityEngine;
using System.Collections;

public class TriggerTest : MonoBehaviour {

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
        Debug.Log("other.name=" + other.name);
        //other.transform.position = other.transform.position + new Vector3(2, 0, 0);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("stay");
        if (other.attachedRigidbody)
        {
            //other.attachedRigidbody.AddForce(Vector3.up * 10);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        if (other.attachedRigidbody)
        {
            //other.attachedRigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
