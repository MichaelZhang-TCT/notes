using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragEventHandler
    : MonoBehaviour
    , IInitializePotentialDragHandler
    , IBeginDragHandler
    , IDragHandler
    , IEndDragHandler
    , IDropHandler
{

	// Use this for initialization
	void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        Debug.Log("OnInitializePotentialDrag:" + gameObject.name);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag:" + gameObject.name);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag:" + gameObject.name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag:" + gameObject.name);
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop:" + gameObject.name + ", " + eventData.pointerDrag.name);
    }
}
