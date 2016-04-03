using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DynamicLayoutGroup : MonoBehaviour {

    public Button template;

    private static int index = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddTemplate();
        }
	}

    private void AddTemplate()
    {
        // 1. Instantiate template
        Button button = GameObject.Instantiate<Button>(template);
        // 2. Set the template parent to the layout group
        button.transform.SetParent(transform);
        // 3. customize copy
        Text buttonText = button.GetComponentInChildren<Text>();
        buttonText.text = "Button " + ++index;
    }
}
