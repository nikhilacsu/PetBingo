using UnityEngine;
using TMPro;
public class PlayersName : MonoBehaviour
{
    public string userNames;
    // This method is used to display the name of the player in every screen
    void Start()
    {
        GetComponent<TMP_Text>().text = PlayerPrefs.GetString("Name")+"'s";
    }
}
