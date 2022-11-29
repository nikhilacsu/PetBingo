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
    public Text  EasyPercentage, MedPercentage, HardPercentage, EasyCorrect, MedCorrect, HardCorrect;
    public TextMeshProUGUI PlayerName,editText;
    void Start()
    {
        EasyCorrect.GetComponent<Text>().text = "Answered correctly "+ FA.easyScore  +" out of "+FA.easyProblemCount +" questions";
        MedCorrect.GetComponent<Text>().text = "Answered correctly " + FA.medScore + " out of " + FA.medProblemCount + " questions";
        HardCorrect.GetComponent<Text>().text = "Answered correctly " + FA.hardScore + " out of " + FA.hardProblemCount + " questions";


        if (FA.easyProblemCount != 0)
        {
            EasyPercentage.GetComponent<Text>().text = (int)((FA.easyScore / (float)FA.easyProblemCount) * 100) + "%";
        }
        else
        {
            EasyPercentage.GetComponent<Text>().text = 0 + "%";
        }
        if (FA.hardProblemCount != 0)
        {
            MedPercentage.GetComponent<Text>().text = (int)((FA.medScore / (float)FA.medProblemCount) * 100) + "%";
        }
        else
        {
            MedPercentage.GetComponent<Text>().text= 0 + "%";
        }
        if (FA.hardProblemCount != 0)
        {
            HardPercentage.GetComponent<Text>().text = (int)((FA.hardScore / (float)FA.hardProblemCount) * 100) + "%";
        }
        else
        {
            HardPercentage.GetComponent<Text>().text = 0 + "%";
        }
    }

    public void deletePlayer()
    {
        EasyCorrect.GetComponent<Text>().text = "Answered correctly 0 out 0 times.";
        MedCorrect.GetComponent<Text>().text = "Answered correctly 0 out 0 times.";
        HardCorrect.GetComponent<Text>().text = "Answered correctly 0 out 0 times.";
        FA.easyScore = 0;
        FA.medScore = 0;
        FA.hardScore = 0;
        FA.hardProblemCount = 0;
        FA.medProblemCount = 0;
        FA.easyProblemCount = 0;
        EasyPercentage.GetComponent<Text>().text = 0 + "%";
        MedPercentage.GetComponent<Text>().text = 0+ "%";
        HardPercentage.GetComponent<Text>().text = 0 + "%";
    }
    public void resetPlayer()
    {
        PlayerName.GetComponent<TMP_Text>().text = "PLAYER1";
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
