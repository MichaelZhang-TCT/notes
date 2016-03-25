using UnityEngine;
using System.Collections;

public class QuaternionTest : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
        Quaternion initRotation = transform.rotation;
        Debug.Log("Quaternion initRotation=" + initRotation);

        Quaternion targetRotation = target.transform.rotation;
        Debug.Log("Quaternion targetRotation=" + targetRotation);
    }
	
	// Update is called once per frame
	void Update () {
        // 1. get current rotation
        Quaternion rotation = transform.rotation;
        Debug.Log("Quaternion rotation=" + rotation);

        // 2. get target direction vector
        Vector3 direction = (target.transform.position - transform.position);
        Debug.Log("Vector3 direction=" + direction);

        // 3. create target rotation
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        Debug.Log("Quaternion targetRotation=" + targetRotation);

        // 4. directly set to target rotation
        //transform.rotation = targetRotation;

        // 4. calculate the interplate rotation by step, and set the rotation to that value
        // interplate to target rotation
        Quaternion interplateRotation = transform.rotation = Quaternion.RotateTowards(rotation, targetRotation, 1);
        Debug.Log("Quaternion interplateRotation=" + interplateRotation);
    }
}
