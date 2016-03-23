using UnityEngine;
using System.Collections;

public class ScriptLifcycle : MonoBehaviour {

    void Awake()
    {
        Debug.Log("Awake");
    }

	// Use this for initialization
    void Start()
    {
        Debug.Log("Start");
	}

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate" + ".deltaTime=" + Time.deltaTime);
    }

	// Update is called once per frame
	void Update()
    {
        Debug.Log("Update=" + ".deltaTime=" + Time.deltaTime);
	}

    void LateUpdate()
    {
        Debug.Log("LateUpdate" + ".deltaTime=" + Time.deltaTime);
    }
}
