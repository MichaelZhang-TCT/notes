using UnityEngine;
using System.Collections;

namespace MonoBehaviours
{
    public class CoroutineTest : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        void OnMouseDown()
        {
            Debug.Log("------------------Start OnMouseDown");

            //StartCoroutine(ScheduleMove());
            //StartCoroutine(YieldReturnNull());
            //StartCoroutine(YieldReturnWaitForEndOfFrame());
            StartCoroutine(YieldReturnWaitForFixedUpdate());

            Debug.Log("------------------End OnMouseDown");
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("Update:" + Time.time);
        }

        IEnumerator ScheduleMove()
        {
            Debug.Log("------------------Start ScheduleMove");
            yield return new WaitForSeconds(1F);

            for (int i = 0; i < 10; i++)
            {
                Debug.Log("------------------Move a step");
                transform.Translate(1F, 0, 0);
                //yield return null; // hang the loop until next frame
            }

            Debug.Log("------------------Compolete loop");
            yield return null;

            transform.position = new Vector3(0, 2F, 0);
            Debug.Log("------------------End ScheduleMove");
        }

        IEnumerator YieldReturnNull()
        {
            Debug.Log("------------------Start YieldReturnNull");
            yield return null;
            Debug.Log("------------------End YieldReturnNull");
        }

        IEnumerator YieldReturnWaitForEndOfFrame()
        {
            Debug.Log("------------------Start YieldReturnWaitForEndOfFrame");
            yield return new WaitForEndOfFrame();
            Debug.Log("------------------End YieldReturnWaitForEndOfFrame");
        }

        IEnumerator YieldReturnWaitForFixedUpdate()
        {
            Debug.Log("------------------Start YieldReturnWaitForFixedUpdate");
            yield return new WaitForFixedUpdate();
            Debug.Log("------------------End YieldReturnWaitForFixedUpdate");
        }

        IEnumerator YieldReturnReturnStartCoroutine()
        {
            Debug.Log("------------------Start YieldReturnReturnStartCoroutine");
            yield return StartCoroutine(YieldReturnNull());
            Debug.Log("------------------End YieldReturnReturnStartCoroutine");
        }
    }
}

