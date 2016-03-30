using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {

    public GUIContent content;
    public GUIStyle style;

    private string textField = "Text"; // default value for text field
    private string textArea = "Area";
    private string password = "abc";

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    void OnGUI()
    {
        // Label
        GUI.Label(new Rect(100, 0, 200, 30), content, style);
        GUI.Label(new Rect(100, 30, 200, 30), GUI.tooltip);

        // Box
        GUI.Box(new Rect(100, 60, 200, 60), content);

        // Button
        if (GUI.Button(new Rect(100, 140, 200, 30), content.text))
        {
            Debug.Log("button clicked");
        }

        // Repeat button
        if (GUI.RepeatButton(new Rect(100, 190, 200, 30), content.text))
        {
            Debug.Log("repeat button clicked");
        }

        // TextField
        textField = GUI.TextField(new Rect(100, 240, 200, 30), textField, 100);

        // TextArea
        textArea = GUI.TextArea(new Rect(100, 290, 200, 30), textArea, 100);

        // PasswordField
        password = GUI.PasswordField(new Rect(100, 340, 200, 30), password, '*');
    }
}
