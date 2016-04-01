using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectEventHandler
    : MonoBehaviour
    , IPointerClickHandler
    , ISelectHandler
    , IUpdateSelectedHandler
    , IDeselectHandler
{

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        EventSystem.current.SetSelectedGameObject(gameObject);
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("OnSelect:" + gameObject.name);
    }

    public void OnUpdateSelected(BaseEventData eventData)
    {
        Debug.Log("OnUpdateSelected:" + gameObject.name);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        Debug.Log("OnDeselect:" + gameObject.name);
    }
}
