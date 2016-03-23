using UnityEngine;
using System.Collections;

public class RoleController : MonoBehaviour {

    public GameObject backpack;
    private TestScript test;

	// Use this for initialization
	void Start()
    {
        Debug.Log("RoleController.Start.1");
        test = backpack.AddComponent<TestScript>(); // Invoke Awake of TestScript now

        Debug.Log("RoleController.Start.2");
        test.getObj(backpack);

        Debug.Log("RoleController.Start.3");
	}
	
	// Update is called once per frame
	void Update()
    {
        Debug.Log("RoleController.Update");
        if (backpack != null)
        {
            backpack.transform.position = new Vector3(
                backpack.transform.position.x,
                backpack.transform.position.y + 0.1f,
                backpack.transform.position.z);
        }
	}
}
