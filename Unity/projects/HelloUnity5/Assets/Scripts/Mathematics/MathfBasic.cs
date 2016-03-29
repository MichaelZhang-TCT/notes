using UnityEngine;
using System.Collections;

namespace Mathematics
{
    public class MathfBasic : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            TestCeil();
            TestFloor();
            TestRound();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void TestCeil()
        {
            Debug.Log("Ceil:10.0F=" + Mathf.Ceil(10.0F));
            Debug.Log("Ceil:10.20F=" + Mathf.Ceil(10.20F));
            Debug.Log("Ceil:10.7F=" + Mathf.Ceil(10.7F));
            Debug.Log("Ceil:-10.0F=" + Mathf.Ceil(-10.0F));
            Debug.Log("Ceil:-10.2F=" + Mathf.Ceil(-10.2F));
            Debug.Log("Ceil:-10.7F=" + Mathf.Ceil(-10.7F));
        }

        private void TestFloor()
        {
            Debug.Log("Floor:10.0F=" + Mathf.Floor(10.0F));
            Debug.Log("Floor:10.20F=" + Mathf.Floor(10.20F));
            Debug.Log("Floor:10.7F=" + Mathf.Floor(10.7F));
            Debug.Log("Floor:-10.0F=" + Mathf.Floor(-10.0F));
            Debug.Log("Floor:-10.2F=" + Mathf.Floor(-10.2F));
            Debug.Log("Floor:-10.7F=" + Mathf.Floor(-10.7F));
        }

        private void TestRound()
        {
            Debug.Log("Round:10.0F=" + Mathf.Round(10.0F));
            Debug.Log("Round:10.20F=" + Mathf.Round(10.20F));
            Debug.Log("Round:10.7F=" + Mathf.Round(10.7F));
            Debug.Log("Round:-10.0F=" + Mathf.Round(-10.0F));
            Debug.Log("Round:-10.2F=" + Mathf.Round(-10.2F));
            Debug.Log("Round:-10.7F=" + Mathf.Round(-10.7F));

            Debug.Log("Round:10.5F=" + Mathf.Round(10.5F));
            Debug.Log("Round:10.5F=" + Mathf.Round(11.5F));
            Debug.Log("Round:-10.5F=" + Mathf.Round(-10.5F));
            Debug.Log("Round:-10.5F=" + Mathf.Round(-11.5F));
        }
    }
}
