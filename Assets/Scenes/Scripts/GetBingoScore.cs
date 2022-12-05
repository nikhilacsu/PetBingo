using TMPro;
using UnityEngine;

public class GetBingoScore : MonoBehaviour
{
    public static GetBingoScore Instance;
    // Start is called before the first frame update
    public void Start()
    {
        //These variables are used to set the text of the fruit count
        GameObject.Find("appleText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementAppleBingo").ToString();
        GameObject.Find("strawberryText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementStrawBingo").ToString();
        GameObject.Find("grapesText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementGrapesBingo").ToString();
    }
}
