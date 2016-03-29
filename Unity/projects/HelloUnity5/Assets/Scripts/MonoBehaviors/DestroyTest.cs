using UnityEngine;
using System.Collections;

public class DestroyTest : MonoBehaviour {

    public float destroyDelay = 2F;

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>(), destroyDelay);
        }
	}
}
