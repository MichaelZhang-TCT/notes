using UnityEngine;
using System.Collections;

namespace Mathematics
{
    public class RandomTest : MonoBehaviour
    {
        private const int count = 30;

        // Use this for initialization
        void Start()
        {
            GameObject cube = transform.GetChild(0).gameObject;

            while (transform.childCount < count)
            {
                GameObject cubeCopy = GameObject.Instantiate(cube);
                cubeCopy.transform.parent = transform;
                randomCube(cubeCopy);
            }
        }

        // Update is called once per frame
        void Update()
        {
            for (int i = 0, count = transform.childCount; i < count; i++)
            {
                Transform child = transform.GetChild(i);
                randomCube(child.gameObject);
            }

            Random.seed = 131515;
            randomValue();
        }

        private void randomCube(GameObject cube)
        {
            //Quaternion randomRotation = Random.rotation;
            Quaternion randomRotation = Random.rotationUniform;
            cube.transform.rotation = randomRotation;

            Color randomColor = new Color(Random.value, Random.value, Random.value);
            cube.GetComponent<MeshRenderer>().material.color = randomColor;
        }

        private void randomValue()
        {
            for (int i = 0; i < 5; i++)
            {
                float rand = Random.value;
                Debug.Log(string.Format("rand[{0}]=" + rand, i));
            }
        }
    }
}
