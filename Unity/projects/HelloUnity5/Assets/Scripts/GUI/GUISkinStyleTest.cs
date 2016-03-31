using UnityEngine;
using System.Collections;

public class GUISkinStyleTest : MonoBehaviour {

    public GUISkin guiSkin;
    public GUIStyle guiStyle;

    private Rect windowRect;

	// Use this for initialization
	void Start()
    {
        windowRect = new Rect(0, 0, 510, 350);
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    void OnGUI()
    {
        GUI.skin = guiSkin;
        windowRect = GUI.Window(0, windowRect, MyWindow, "window");
    }

    private void MyWindow(int windowId)
    {
        GUILayout.BeginVertical();

        GUILayout.Space(8);
        GUILayout.Button("Button", guiStyle); // content, GUIStyle name
        GUILayout.Space(8);
        GUILayout.Label("Label", "Button"); // content, GUIStyle name

        GUILayout.EndVertical();

        GUI.DragWindow();
    }
}
