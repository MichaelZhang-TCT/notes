using UnityEngine;
using System.Collections;

namespace Inputs
{
    public class InputTest : MonoBehaviour
    {
        public GameObject movingObject;
        public float fullSpeedH = 5F;
        public float fullSpeedV = 5F;
        public float jumpHeight = 10F;

        private string message = "";
        private float speedH = 0;
        private float speedV = 0;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //MouseInput();
            //GetAxis();
            MoveObject();
        }

        void OnGUI()
        {
            GUILayout.TextArea(message, 200);
        }

        private void MouseInput()
        {
            var mousePosition = Input.mousePosition;
            message = "mouse pos:" + mousePosition.ToString() + '\n';

            bool leftClick = Input.GetMouseButton(0); // left click
            message += "mouse left:" + leftClick + '\n';
        }

        private void GetAxis()
        {
            var horizontalValue = Input.GetAxis("Horizontal");
            message = "horizontal=" + horizontalValue + '\n';
        }

        private void MoveObject()
        {
            var horizontalValue = Input.GetAxis("Horizontal");
            speedH = horizontalValue * fullSpeedH;

            var verticalValue = Input.GetAxis("Vertical");
            speedV = verticalValue * fullSpeedV;

            bool jump = Input.GetButtonDown("Jump");

            if (movingObject != null)
            {
                // move
                movingObject.transform.Translate(speedH * Time.deltaTime, 0, speedV * Time.deltaTime);
                // jump
                if (jump)
                {
                    movingObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                }
            }

            message = "Horizontal:" + horizontalValue + '\n';
            message += "Vertical:" + verticalValue;
            message = "HorizontalRaw:" + Input.GetAxisRaw("Horizontal");
        }
    }
}
