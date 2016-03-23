using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

    [SerializeField]
    public GameObject obj;

    void Awake()
    {
        Debug.Log("TestScript.Awake.1");
        obj = GameObject.Find("Cube");
        Debug.Log("TestScript.Awake.2");
    }

	// Use this for initialization
	void Start()
    {
        Debug.Log("TestScript.Start.1");
        //obj = GameObject.Find("Cube");
        Debug.Log("TestScript.Start.2");
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    public void getObj(GameObject go)
    {
        Debug.Log("TestScript.getObj.1");
        if (obj == null)
        {
            Debug.LogError("obj is null!");
            return;
        }
        Debug.Log("TestScript.getObj.2");

        go.transform.parent = obj.transform;
        Debug.Log("TestScript.getObj.3");
    }
}
