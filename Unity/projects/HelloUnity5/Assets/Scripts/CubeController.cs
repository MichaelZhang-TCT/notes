using UnityEngine;
using System.Collections;

namespace HelloUnity
{
    public class CubeController : MonoBehaviour
    {

        public float speed; // visible

        protected float mass; // invisible;

        [SerializeField]
        GameObject attachment; // visible

        [HideInInspector]
        public float color; // invisible

        public EnumType enumType;

        [SerializeField]
        public Backpack backpack;

        public string f = "2";

        public enum EnumType
        {
            TypeA, TypyeB, TypeC
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + speed * Time.deltaTime,
                transform.position.z);
        }

        void LateUpdate()
        {
            speed += 0.01f;
        }
    }

    [System.Serializable]
    public class Backpack
    {
        public int capacity = 3;
    }
}
