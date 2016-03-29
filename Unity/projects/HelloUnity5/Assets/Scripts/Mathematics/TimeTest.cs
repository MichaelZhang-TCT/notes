using UnityEngine;
using System.Collections;

namespace Mathematics
{
    public class TimeTest : MonoBehaviour
    {

        public int frameRate;

        // Use this for initialization
        void Start()
        {
            frameRate = Time.captureFramerate;
        }

        // Update is called once per frame
        void Update()
        {
            Time.captureFramerate = frameRate;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 0.2f;
                Time.fixedDeltaTime = 0.005f;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                Time.timeScale = 1f;
                Time.fixedDeltaTime = 0.02f;
            }
        }

        void OnGUI()
        {
            int fixedWidth = 300;
            GUILayoutOption option = GUILayout.Width(fixedWidth);

            // Read only
            // time
            GUILayout.TextArea("Time.time: " + Time.time, option);
            GUILayout.TextArea("Time.unscaledTime: " + Time.unscaledTime, option);
            GUILayout.TextArea("Time.timeSinceLevelLoad: " + Time.timeSinceLevelLoad, option);
            GUILayout.TextArea("Time.realtimeSinceStartup: " + Time.realtimeSinceStartup, option);
            // delta time
            GUILayout.TextArea("Time.deltaTime: " + Time.deltaTime, option);
            GUILayout.TextArea("Time.smoothDeltaTime: " + Time.smoothDeltaTime, option);
            GUILayout.TextArea("Time.unscaledDeltaTime: " + Time.unscaledDeltaTime, option);

            // Modifiable
            GUILayout.TextArea("Time.maximumDeltaTime: " + Time.maximumDeltaTime, option);
            GUILayout.TextArea("Time.captureFramerate: " + Time.captureFramerate, option);
            GUILayout.TextArea("Time.fixedDeltaTime: " + Time.fixedDeltaTime, option);
            GUILayout.TextArea("Time.tmieScale: " + Time.timeScale, option);

            GUILayout.TextArea("Time.frameCount: " + Time.frameCount, option); // Read only
            GUILayout.TextArea("Time.frameRate: " + 1f / Time.deltaTime, option);
        }
    }
}

