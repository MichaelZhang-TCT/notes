using UnityEngine;
using System.Collections;

namespace Mathematics
{
    public class MathfInterpolate : MonoBehaviour
    {
        public float minX = 0F;
        public float maxX = 5F;

        public float startAngle = 0F;
        public float endAngle = 90F;

        public float targetX = 5F;
        public float maxSpeed = 999;
        public float duration = 2F;

        public float targetAngle = 90F;
        public float maxEulerSpeed = 30F;

        private float startTime = 1F;

        private float startX;
        private float startAngleX;
        private float velocity = 0F;
        private float eulerVelocity = 0F;

        // Use this for initialization
        void Start()
        {
            startX = transform.position.x;
            startAngleX = transform.eulerAngles.x;
        }

        // Update is called once per frame
        void Update()
        {
            //Lerp();
            //LerpAngle();
            //SmoothDamp();
            //SmootDampAngle();
            //SmoothStep();
            MoveTowards();
        }

        private void Lerp()
        {
            transform.position = new Vector3(
                Mathf.Lerp(minX, maxX, Time.time - startTime) + startX,
                //Mathf.Lerp(transform.position.x, maxX, Time.deltaTime),
                transform.position.y,
                transform.position.z);
        }

        private void LerpAngle()
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                Mathf.LerpAngle(startAngle, endAngle, Time.time - startTime) + startAngleX,
                transform.eulerAngles.z);
        }

        private void SmoothDamp()
        {
            transform.position = new Vector3(
                Mathf.SmoothDamp(transform.position.x, targetX, ref velocity, duration, maxSpeed),
                transform.position.y,
                transform.position.z);
        }

        private void SmootDampAngle()
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref eulerVelocity, duration, maxEulerSpeed),
                transform.eulerAngles.z);
        }

        private void SmoothStep()
        {
            transform.position = new Vector3(
                //Mathf.Lerp(minX, maxX, Time.time - startTime) + startX,
                Mathf.SmoothStep(minX, maxX, Time.time - startTime) + startX,
                transform.position.y,
                transform.position.z);
        }

        private void MoveTowards()
        {
            transform.position = new Vector3(
                Mathf.MoveTowards(transform.position.x, maxX, maxSpeed * Time.deltaTime),
                transform.position.y,
                transform.position.z);
        }
    }
}
