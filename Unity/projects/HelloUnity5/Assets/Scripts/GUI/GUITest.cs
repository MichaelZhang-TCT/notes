using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {

    public Rect labelPosition;
    public string labelString;
    public Texture labelTexture;
    public string labelTooltip;
    public GUIContent labelContent;

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
        Label();
    }

    private void Label()
    {
        GUI.Label(labelPosition, labelContent);

        GUI.Label(new Rect(100, 200, 100, 100), new GUIContent(labelString, labelTexture, labelTooltip));

        GUI.Label(new Rect(100, 300, 100, 100), GUI.tooltip);
    }
}
