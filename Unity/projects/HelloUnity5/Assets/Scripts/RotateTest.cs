using UnityEngine;
using System.Collections;

public class RotateTest : MonoBehaviour {

    public float speed = 60;

    public GameObject target;

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
        RotateTo();
	}

    private void SelfRotate()
    {
        //float angle = speed * Time.deltaTime;
        //transform.Rotate(angle, angle * 2, angle);

        //transform.Rotate(Vector3.up * speed * Time.deltaTime);
        Vector3 axis = new Vector3(1, 2, 4);
        transform.Rotate(axis, speed * Time.deltaTime);

        Vector3 topVertex = axis.normalized * 5 + transform.position;
        Vector3 bottomVertex = -axis.normalized * 5 + transform.position;

        Debug.DrawLine(topVertex, bottomVertex, Color.red);
    }

    private void RotateArount()
    {
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);

        Debug.DrawLine(target.transform.position + Vector3.up * 5, target.transform.position + Vector3.up * -5);
    }

    private void RotateTo()
    {
        Quaternion currentRotation = transform.rotation;
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, speed * Time.deltaTime);
    }
}
