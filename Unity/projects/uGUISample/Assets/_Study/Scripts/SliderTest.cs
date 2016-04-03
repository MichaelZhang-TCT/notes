using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnValueChange(float value)
    {
        Debug.Log("value=" + value);
    }
}
