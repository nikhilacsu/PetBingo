using UnityEngine;
using UnityEngine.EventSystems;

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
            MoveRabbitToReward();
        }
    }
    //This method is used to move the rabbit toward the fruit
    public void MoveRabbitToReward()
    {
        mouse.transform.position = Vector2.MoveTowards(mouse.transform.position, position, speed * Time.deltaTime);
        Destroy(gameObject, 3);
       
    }
}
