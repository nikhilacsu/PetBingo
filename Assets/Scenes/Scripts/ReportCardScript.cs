using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;
using System.Linq;
using Fractions; //Nugget Package
using UnityEngine.EventSystems;
using System.Diagnostics.Tracing; 
using TMPro;

public class ReportCardScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static ReportCardScript Instance;
    public Text  EasyPercentage, MedPercentage, HardPercentage, EasyCorrect, MedCorrect, HardCorrect;
    public TextMeshProUGUI PlayerName,editText;
    public void Start()
    {
        EasyCorrect.GetComponent<Text>().text = "Answered correctly "+ PlayerPrefs.GetInt("easyScore")  +" out of "+ PlayerPrefs.GetInt("easyProblemCount") + " questions";
        MedCorrect.GetComponent<Text>().text = "Answered correctly " + PlayerPrefs.GetInt("medScore") + " out of " + PlayerPrefs.GetInt("medProblemCount") + " questions";
        HardCorrect.GetComponent<Text>().text = "Answered correctly " + PlayerPrefs.GetInt("hardScore") + " out of " + PlayerPrefs.GetInt("hardProblemCount") + " questions";
        
        if (PlayerPrefs.GetInt("easyProblemCount") != 0)
        {
            EasyPercentage.GetComponent<Text>().text = (int)((PlayerPrefs.GetInt("easyScore") / (float)PlayerPrefs.GetInt("easyProblemCount")) * 100) + "%";
        }
        else
        {
            EasyPercentage.GetComponent<Text>().text = 0 + "%";
        }
        if (PlayerPrefs.GetInt("medProblemCount") != 0)
        {
            MedPercentage.GetComponent<Text>().text = (int)((PlayerPrefs.GetInt("medScore") / (float)PlayerPrefs.GetInt("medProblemCount")) * 100) + "%";
        }
        else
        {
            MedPercentage.GetComponent<Text>().text= 0 + "%";
        }
        if (PlayerPrefs.GetInt("hardProblemCount") != 0)
        {
            HardPercentage.GetComponent<Text>().text = (int)((PlayerPrefs.GetInt("hardScore") / (float)PlayerPrefs.GetInt("hardProblemCount")) * 100) + "%";
        }
        else
        {
            HardPercentage.GetComponent<Text>().text = 0 + "%";
        }
    }

    
    public void deletePlayer()
    {
        PlayerPrefs.SetInt("easyScore", 0);
        PlayerPrefs.SetInt("medScore", 0);
        PlayerPrefs.SetInt("easyScore", 0);
        PlayerPrefs.SetInt("easyProblemCount", 0);
        PlayerPrefs.SetInt("medProblemCount", 0);
        PlayerPrefs.SetInt("hardProblemCount", 0);
        Start();
    }
    public void resetPlayer()
    {
        PlayerPrefs.SetString("Name", "Player");
        PlayerName.GetComponent<TMP_Text>().text = PlayerPrefs.GetString("Name");
    }

    public void editPlayerName()
    {
        PlayerName.GetComponent<TMP_Text>().text=editText.GetComponent<TMP_Text>().text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
