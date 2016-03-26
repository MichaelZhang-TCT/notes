using UnityEngine;
using System.Collections;

public class ScaleTest : MonoBehaviour {

    public AnimationCurve animCurve;

    public float speed = 2;

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
        float scale = animCurve.Evaluate(Time.time * speed) / 2 + 0.5f;

        transform.localScale = new Vector3(scale, scale, scale);
	
	}
}
