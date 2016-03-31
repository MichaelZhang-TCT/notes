using UnityEngine;
using System.Collections;

public class GUILayoutTest : MonoBehaviour {

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
        // Area
        GUILayout.BeginArea(new Rect(500, 50, 200, 80));

        GUILayout.Button("Button 1", GUILayout.MaxWidth(100), GUILayout.MinWidth(8));
        GUILayout.Button("Button 2", GUILayout.MaxWidth(50));
        GUILayout.Button("Button 3", GUILayout.MaxWidth(30));

        GUILayout.EndArea();

        // Horizontal
        GUILayout.BeginHorizontal();

        GUILayout.Button("Button 1");
        GUILayout.Button("Button 2");
        GUILayout.Space(100);
        GUILayout.Button("Button 3");

        GUILayout.EndHorizontal();

        // Vertical
        GUILayout.BeginVertical(GUILayout.Height(200));

        GUILayout.Button("Button 1");
        GUILayout.FlexibleSpace();
        GUILayout.Button("Button 2");
        GUILayout.FlexibleSpace();
        GUILayout.Button("Button 3");

        GUILayout.EndVertical();
    }
}
