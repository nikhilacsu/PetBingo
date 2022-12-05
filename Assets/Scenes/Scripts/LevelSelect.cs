using TMPro;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    //This method is used to get the text for level(easy, medium, hard) selection
    public void getText()
    {
        TextMeshProUGUI txt = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        FA.levelSelect = txt.text;
    }  
}
