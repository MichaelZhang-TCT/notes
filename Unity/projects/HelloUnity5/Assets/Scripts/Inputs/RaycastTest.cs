using UnityEngine;
using System.Collections;

namespace Inputs
{
    public class RaycastTest : MonoBehaviour
    {
        public float detectDistance = 5F;

        private Rigidbody rigidBody;
        private Material material;

        private RaycastHit hitInfo;
        private bool hitTheGround = false;

        // Use this for initialization
        void Start()
        {
            rigidBody = GetComponent<Rigidbody>();
            material = GetComponent<MeshRenderer>().material;
        }

        // Update is called once per frame
        void Update()
        {
            Ray detectedRay = new Ray(transform.position, Vector3.down);

            if (!hitTheGround && Physics.Raycast(detectedRay, out hitInfo, detectDistance))
            {
                material.color = Color.red;

                if (hitInfo.collider.tag == "Environment")
                {
                    rigidBody.drag = -Physics.gravity.y;
                }
            }
            else
            {
                material.color = Color.white;
            }

            Debug.DrawRay(detectedRay.origin, detectedRay.direction.normalized * detectDistance, Color.red);
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Environment")
            {
                rigidBody.drag = 0;
                hitTheGround = true;
            }
        }
    }
}
