using UnityEngine;
using System.Collections;

public class DynamicRemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Remove()
    {
        transform.SetParent(null);
        Destroy(gameObject);
    }
}
