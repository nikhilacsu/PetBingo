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
        if (gameObject.name == "Apple" && PlayerPrefs.GetInt("incrementAppleBingo") > 0)
        {
            PlayerPrefs.SetInt("incrementAppleBingo", (PlayerPrefs.GetInt("incrementAppleBingo") - 1));
            GameObject.Find("appleText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementAppleBingo").ToString();
        }
        else if (gameObject.name == "Strawberry" && PlayerPrefs.GetInt("incrementStrawBingo") > 0)
        {
            PlayerPrefs.SetInt("incrementStrawBingo", PlayerPrefs.GetInt("incrementStrawBingo") - 1);
            GameObject.Find("strawberryText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementStrawBingo").ToString();        }
        else if (gameObject.name == "Grapes" && PlayerPrefs.GetInt("incrementGrapesBingo") > 0)
        {
            PlayerPrefs.SetInt("incrementGrapesBingo", PlayerPrefs.GetInt("incrementGrapesBingo") - 1);
            GameObject.Find("grapesText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementGrapesBingo").ToString();
        }
    }
}
