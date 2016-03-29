using UnityEngine;
using System.Collections;

public class MouseRaycast : MonoBehaviour {

    public Camera mainCamera = null;

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray r = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(r, out hitInfo, 1000F))
            {
                if (hitInfo.collider.tag == "Target")
                {
                    Debug.Log("Mouse raycast hit the target!");
                }
            }

            Debug.DrawRay(r.origin, r.direction.normalized * 1000F, Color.red);
        }
	}
}
