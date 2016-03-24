using UnityEngine;
using System.Collections;

public class TransformTest : MonoBehaviour {

    public MoveDirection moveDirection = MoveDirection.Idle;

    public enum MoveDirection { Idle, Forward, Right, Up }

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
        Vector3 directionVector;
        switch (moveDirection)
        {
            case MoveDirection.Idle:
                directionVector = Vector3.zero;
                break;

            case MoveDirection.Forward:
                directionVector = transform.forward;
                break;

            case MoveDirection.Right:
                directionVector = transform.right;
                break;

            case MoveDirection.Up:
                directionVector = transform.up;
                break;

            default:
                return;
        }

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = directionVector * 1;
	}
}
