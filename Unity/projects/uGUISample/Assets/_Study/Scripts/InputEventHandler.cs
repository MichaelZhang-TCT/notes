using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputEventHandler
    : MonoBehaviour 
    , IScrollHandler
    , IMoveHandler
    , ISubmitHandler
    , ICancelHandler
{

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    public void OnScroll(PointerEventData eventData)
    {
        Debug.Log("OnScroll:" + gameObject.name);
    }

    public void OnMove(AxisEventData eventData)
    {
        Debug.Log("OnMove:" + gameObject.name);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        Debug.Log("OnSubmit:" + gameObject.name);
    }

    public void OnCancel(BaseEventData eventData)
    {
        Debug.Log("OnCancel:" + gameObject.name);
    }
}
