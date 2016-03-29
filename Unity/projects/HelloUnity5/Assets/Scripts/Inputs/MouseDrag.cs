using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {

    public float scaleFactor = 1.3F;
    public float rotateVelocity = 45F;
    public float depth = 20F;
    public Camera camera = null;

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    void OnMouseEnter()
    {
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }

    void OnMouseExit()
    {
        transform.localScale = Vector3.one;
    }

    void OnMouseOver()
    {
        transform.Rotate(Vector3.up, rotateVelocity * Time.deltaTime, Space.Self);
    }

    void OnMouseDrag()
    {
        //Move();
        MoveFixedDepth();
    }

    void Move()
    {
        // ray from mouse position
        Ray r = camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(r, out hitInfo, 1000F, 1)) // hit something in the scene, use layermask to filter the object itself
        {
            // move the object to the hit point
            transform.position = new Vector3(
                hitInfo.point.x,
                hitInfo.point.y + 1F,
                hitInfo.point.z);

            Debug.DrawLine(r.origin, hitInfo.point, Color.red);
        }
    }

    void MoveFixedDepth()
    {
        Vector3 mouseScreen = Input.mousePosition;
        mouseScreen.z = depth;
        Vector3 mouseWorld = camera.ScreenToWorldPoint(mouseScreen);
        transform.position = mouseWorld;

        Debug.Log("mouseScreen=" + mouseScreen + ", mouseWorld=" + mouseWorld);
    }
}
