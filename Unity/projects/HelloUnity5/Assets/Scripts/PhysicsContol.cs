using UnityEngine;
using System.Collections;

public class PhysicsContol : MonoBehaviour {

    Rigidbody rigidBody;

    private float lastHeight;

    public ForceMode forceMode = ForceMode.Force;

	// Use this for initialization
	void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        lastHeight = transform.position.y;
	}
	
    void FixedUpdate()
    {
        //Push();
        //Debug.Log("deltaV=" + rigidBody.velocity);
    }

	// Update is called once per frame
	void Update()
    {
        Debug.Log("Time"
            + ", deltaTime=" + Time.deltaTime
            + ", fixedDeltaTime=" + Time.fixedDeltaTime
            + ", fixedTime=" + Time.fixedTime
            + ", time=" + Time.time
            );

        //Push();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Push();
        }
	
	}

    private void Push()
    {
        if (rigidBody != null)
        {
            rigidBody.AddForce(-Physics.gravity, forceMode);

            Debug.Log("deltaD=" + (transform.position.y - lastHeight));
            lastHeight = transform.position.y;
        }
    }
}
