using UnityEngine;
using System.Collections;

public class TransformTestDirection : MonoBehaviour {

    public GameObject cube;

    void Awake()
    {
        cube = GameObject.Find("TransformBullet");
    }

	// Use this for initialization
	void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
        Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.Q))
        {
            // pull
            // 1. target point at local position
            Vector3 sightPoint = new Vector3(0, 0, 3);
            // 2. convert the target point to world position
            Vector3 sightPointWorldPosition = transform.TransformPoint(sightPoint);
            // 3. set the bullet's world position to target world position
            cube.transform.position = sightPointWorldPosition;

            // 4. make the bullet attach to sight point
            cube.transform.parent = transform;
            // 5. make it kinematic
            cubeRigidbody.isKinematic = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            // push
            if (cube.transform.parent == transform)
            {
                // 1. 
                cubeRigidbody.isKinematic = false;
                cube.transform.parent = null;

                Vector3 worldDirection = transform.TransformDirection(0, 0, 1); // forward
                cubeRigidbody.AddForce(worldDirection * 10, ForceMode.Impulse);
            }
        }
	}
}
