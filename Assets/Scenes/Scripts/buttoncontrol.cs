using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class buttoncontrol : MonoBehaviour
{
    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;
    public static string userName;

    void Start()
    {
        user_name.text = PlayerPrefs.GetString("Name");
    }

    public void setName()
    {
        
        user_name.text = user_inputField.text;
        userName=user_name.text;

        PlayerPrefs.SetString("Name",user_name.text);
        PlayerPrefs.Save();
    }

}
