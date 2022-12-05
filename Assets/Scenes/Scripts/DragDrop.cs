using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour,  IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform m_RectTransform;
    private CanvasGroup m_CanvasGroup;
    public int x_position;
    //Awake is called when the script instance is being loaded
    void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
        m_CanvasGroup = GetComponent<CanvasGroup>(); 
    }
    //This method is called when the gameobject drag is started
    public void OnBeginDrag(PointerEventData eventData)
    {
        m_CanvasGroup.blocksRaycasts = false;
    }
    //This method is called when the gameobject is being dragged
    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    //This method is called when the game object is dropped
    public void OnEndDrag(PointerEventData eventData)
    {
        m_CanvasGroup.blocksRaycasts = true;
    }
}
