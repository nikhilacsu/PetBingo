using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GroundSnap : MonoBehaviour, IDropHandler
{
    public float x_position;

    public static GroundSnap Instance;

    [SerializeField] GameObject mouse;

    public int speed = 10;
    public bool dropped = false;

    public Vector2 position;
  
    public void OnDrop(PointerEventData eventData)
    {
        if (FA.bingoType == "hBingo" && FA.incrementAppleBingo>0)
        {
            FA.incrementAppleBingo -= 1;
            GameObject.Find("appleText").GetComponent<TMP_Text>().text = FA.incrementAppleBingo.ToString();
        }
        else if (FA.bingoType == "vBingo" && FA.incrementStrawBingo > 0)
        {
            FA.incrementStrawBingo -= 1;
            GameObject.Find("strawberryText").GetComponent<TMP_Text>().text = FA.incrementStrawBingo.ToString();
        }
        else if(FA.bingoType == "dBingo" && FA.incrementGrapesBingo > 0)
        {
            FA.incrementGrapesBingo -= 1;
            GameObject.Find("grapesText").GetComponent<TMP_Text>().text = FA.incrementGrapesBingo.ToString();
        }
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            dropped = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(transform.position.x + 1, transform.position.y);
    }
    // Update is called once per frame
    void Update()
    {
            if (dropped)
        {
            MoveMouseToReward();      
        }
    }

    public void MoveMouseToReward()
    {
        mouse.transform.position = Vector2.MoveTowards(mouse.transform.position, position, speed * Time.deltaTime);
        Destroy(gameObject, 3);
    }
}
