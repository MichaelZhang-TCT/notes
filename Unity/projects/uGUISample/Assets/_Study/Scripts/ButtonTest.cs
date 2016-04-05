using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {

    private Button button;

	// Use this for initialization
	void Start () {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnButtonClicked(string param)
    {
        Debug.Log("On button clicked with param:" + param);
    }

    public void OnButtonClicked()
    {
        Debug.Log("On button clicked");

        //button.onClick.RemoveListener(OnButtonClicked);
    }
}
