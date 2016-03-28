using UnityEngine;
using System.Collections;

namespace Mathematics
{
    public class Math3D : MonoBehaviour
    {
        public TowardsType towardsType;
        public GameObject target;
        public float velocity = 1;
        public float angularVelocity = 1;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            switch (towardsType)
            {
                case TowardsType.Move:
                    MoveTowards();
                    break;

                case TowardsType.Rotate:
                    RotateTowards();
                    break;

                default:
                    //Cross();
                    MaxMin();
                    break;
            }
        }

        private void Cross()
        {
            //Vector3 cross = Vector3.Cross(transform.position, Vector3.up);
            Vector3 cross = Vector3.Cross(Vector3.up, transform.position);

            Debug.DrawLine(Vector3.zero, transform.position, Color.magenta);
            Debug.DrawLine(Vector3.zero, cross, Color.yellow);
            Debug.DrawLine(Vector3.zero, Vector3.up, Color.cyan);

            Debug.Log(string.Format("direction={0}, magnitude={1}", cross.normalized, cross.magnitude));
        }

        private void MaxMin()
        {
            DrawDebugLine();

            Debug.DrawLine(Vector3.zero, Vector3.Max(transform.position, target.transform.position), Color.white);
            Debug.DrawLine(Vector3.zero, Vector3.Min(transform.position, target.transform.position), Color.black);

        }

        private void MoveTowards()
        {
            DrawDebugLine();

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position,
                velocity * Time.deltaTime); // maxDistanceDelta
        }

        private void RotateTowards()
        {
            DrawDebugLine();

            transform.position = Vector3.RotateTowards(transform.position, target.transform.position,
                angularVelocity * Time.deltaTime, // maxRadiansDelta
                velocity * Time.deltaTime); // maxMagnitudeDelta
        }

        private void DrawDebugLine()
        {
            Debug.DrawLine(Vector3.zero, transform.position, Color.cyan);
            Debug.DrawLine(Vector3.zero, target.transform.position, Color.yellow);
        }
    }

    public enum TowardsType { None, Move, Rotate }
}
