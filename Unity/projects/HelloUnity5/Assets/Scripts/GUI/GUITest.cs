using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {

    public GUIContent content;
    public GUIStyle style;

    private string textField = "Text"; // default value for text field
    private string textArea = "Area";
    private string password = "abc";
    private bool toggle = true;
    private int toolbarSelected = 0;
    private string[] toolbarChoices = { "A", "B", "C", "D" };
    private int selectionGridSelected = 0;
    private string[] selectionGridChoices = { "V", "W", "X", "Y", "Z" };
    private int selectionGridHorizonCOunt = 3;
    private float horizontalSliderValue = 0;
    private float verticalSliderValue = 0;
    private float horizontalScrollbarValue = 0;
    private float verticalScrollbarValue = 0;
    private Vector2 scrollbarPosition = Vector2.zero;
    private Rect windowPosition = new Rect(600, 150, 200, 80);

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
        if (GUI.Button(new Rect(100, 140, 200, 30), "Button"))
        {
            Debug.Log("button clicked");
        }

        // Repeat button
        if (GUI.RepeatButton(new Rect(100, 190, 200, 30), "Repeat Button"))
        {
            Debug.Log("repeat button clicked");
        }

        // TextField
        textField = GUI.TextField(new Rect(100, 240, 200, 30), textField, 100);

        // TextArea
        textArea = GUI.TextArea(new Rect(100, 290, 200, 30), textArea, 100);

        // PasswordField
        password = GUI.PasswordField(new Rect(100, 340, 200, 30), password, '*');

        // Toggle
        toggle = GUI.Toggle(new Rect(350, 0, 200, 30), toggle, content.text);

        // Toolbar
        toolbarSelected = GUI.Toolbar(new Rect(350, 50, 200, 30), toolbarSelected, toolbarChoices);

        // SelectionGrid
        selectionGridSelected = GUI.SelectionGrid(new Rect(350, 100, 200, 80), selectionGridSelected, selectionGridChoices, selectionGridHorizonCOunt);

        // HorizontalSlider
        horizontalSliderValue = GUI.HorizontalSlider(new Rect(350, 200, 160, 30), horizontalSliderValue, 0F, 100F);
        GUI.Label(new Rect(520, 200, 30, 30), (int)horizontalSliderValue + "");

        // HorizontalScrollbar
        horizontalScrollbarValue = GUI.HorizontalScrollbar(new Rect(350, 250, 160, 30), horizontalScrollbarValue, 10F, 0F, 100F);
        GUI.Label(new Rect(520, 250, 30, 30), (int)horizontalScrollbarValue + "");

        // VerticalSlider
        verticalSliderValue = GUI.VerticalSlider(new Rect(350, 300, 30, 80), verticalSliderValue, 0F, 100F);
        GUI.Label(new Rect(390, 300, 30, 80), (int)verticalSliderValue + "");

        // VerticalScrollbar
        verticalScrollbarValue = GUI.VerticalScrollbar(new Rect(430, 300, 30, 80), verticalScrollbarValue, 10F, 0F, 100F);
        GUI.Label(new Rect(470, 300, 30, 80), (int)verticalScrollbarValue + "");

        // ScrollView
        scrollbarPosition = GUI.BeginScrollView(new Rect(600, 50, 200, 80), scrollbarPosition, new Rect(0, 0, 400, 160));
        GUI.Button(new Rect(0, 0, 80, 30), "Top-Left");
        GUI.Button(new Rect(120, 0, 80, 30), "Top-Right");
        GUI.Button(new Rect(0, 50, 80, 30), "Bottom-Left");
        GUI.Button(new Rect(120, 50, 80, 30), "Bottom-Right");
        GUI.EndScrollView();

        // Window
        windowPosition = GUI.Window(0, windowPosition, WindowFunc, "Window");
    }

    private void WindowFunc(int windowId)
    {
        GUI.Button(new Rect(10, 30, 80, 30), "Button");
        GUI.DragWindow();
    }
}
