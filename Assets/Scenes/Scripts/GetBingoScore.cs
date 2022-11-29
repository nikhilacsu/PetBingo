using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetBingoScore : MonoBehaviour
{
    public static GetBingoScore Instance;

    // Start is called before the first frame update
    public void Start()
    {
        GameObject.Find("appleText").GetComponent<TMP_Text>().text = FA.incrementAppleBingo.ToString();
        GameObject.Find("strawberryText").GetComponent<TMP_Text>().text = FA.incrementStrawBingo.ToString();
        GameObject.Find("grapesText").GetComponent<TMP_Text>().text = FA.incrementGrapesBingo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
