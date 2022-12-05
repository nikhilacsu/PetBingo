using UnityEngine;
using TMPro;
public class buttoncontrol : MonoBehaviour
{
    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;
    //When ever the screen starts the name will be displayed in the player name
    void Start()
    {
        user_name.text = PlayerPrefs.GetString("Name");
    }
    //This function is used to set name in the button.
    public void setName()
    {
        if (user_inputField.ToString() == "") 
        {
            user_name.text = "Player";
        }
        else
        {
            user_name.text = user_inputField.text;
        }
        //If the user name is changed then the data of that particular user will be deleted
        PlayerPrefs.SetString("Name",user_name.text);
        PlayerPrefs.SetInt("easyScore", 0);
        PlayerPrefs.SetInt("medScore", 0);
        PlayerPrefs.SetInt("hardScore", 0);
        PlayerPrefs.SetInt("easyProblemCount", 0);
        PlayerPrefs.SetInt("medProblemCount", 0);
        PlayerPrefs.SetInt("hardProblemCount", 0);
        PlayerPrefs.Save();
    }
}
