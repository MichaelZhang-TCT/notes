using UnityEngine;
using System.Collections;

namespace Mathematics
{
    public class MathOthers : MonoBehaviour
    {
        public float maxScale = 2F;
        public Material material;

        private float scale = 1F;
        private Vector3 colorSpace;

        // Use this for initialization
        void Start()
        {
            material = gameObject.GetComponent<MeshRenderer>().material;

            colorSpace = new Vector3(
                Random.Range(0F, 10F),
                Random.Range(0F, 10F),
                Random.Range(0F, 10F)
                );
        }

        // Update is called once per frame
        void Update()
        {
            PerlinNoise();
        }

        private void Repeat()
        {
            scale = Mathf.Repeat(Time.time, maxScale);

            transform.localScale = new Vector3(1, scale, 1);
        }

        private void PingPong()
        {
            scale = Mathf.PingPong(Time.time, maxScale);

            transform.localScale = new Vector3(1, scale, 1);
        }

        private void PerlinNoise()
        {
            float x = Time.time;

            float sX = Mathf.PerlinNoise(x, colorSpace.x);
            float sY = Mathf.PerlinNoise(x, colorSpace.y);
            float sZ = Mathf.PerlinNoise(x, colorSpace.z);

            material.color = new Color(sX, sY, sZ);
        }
    }
}
