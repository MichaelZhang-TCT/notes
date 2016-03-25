using UnityEngine;
using System.Collections;

public class TranslateTest : MonoBehaviour {

    public float speed = 2;
    public AnimationCurve animCurve;
    public GameObject target;

    private GameObject anchor;


	// Use this for initialization
	void Start()
    {
        anchor = GameObject.Find("TranslateAnchor");
	}
	
	// Update is called once per frame
	void Update()
    {
        //float translateZ = speed * Time.deltaTime;
        //Vector3 translate = new Vector3(0, 0, translateZ);

        AccurateMoveTo();
	}

    private void SimpleTranslate(Vector3 translate)
    {
        //transform.position = new Vector3(
        //    transform.position.x,
        //    transform.position.y,
        //    transform.position.z + translateZ);

        // equivalent to above
        transform.Translate(translate); // space = Space.Self
    }

    private void WorldTranslate(Vector3 translate)
    {
        transform.Translate(translate, Space.World);
    }

    private void RelativeTranslate(Vector3 translate)
    {
        if (anchor != null)
        {
            transform.Translate(translate, anchor.transform);
        }
    }

    private void AnimationCurve()
    {
        if (animCurve == null)
        {
            return;
        }

        float evaluateValue = animCurve.Evaluate(Time.time);

        transform.position = new Vector3(3 * evaluateValue, transform.position.y, transform.position.z);
    }

    private void MoveTo()
    {
        if (transform.position != target.transform.position)
        {
            transform.Translate((target.transform.position - transform.position).normalized * speed * Time.deltaTime, Space.World);
        }
    }

    private void AccurateMoveTo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 1)
        {
            Vector3 direction = target.transform.position - transform.position;
            direction = direction.normalized;
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
    }


}
