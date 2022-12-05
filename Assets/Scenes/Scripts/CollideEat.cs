using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CollideEat : MonoBehaviour
{
    //This method is used to animate the fruit if it is near to the rabbit
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInChildren<Animator>().enabled = true;
        Destroy(gameObject, 1);
        if (gameObject.name == "Apple" && PlayerPrefs.GetInt("incrementAppleBingo") > 0)
        {
            PlayerPrefs.SetInt("incrementAppleBingo", (PlayerPrefs.GetInt("incrementAppleBingo") - 1));
            GameObject.Find("appleText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementAppleBingo").ToString();
        }
        else if (gameObject.name == "Strawberry" && PlayerPrefs.GetInt("incrementStrawBingo") > 0)
        {
            PlayerPrefs.SetInt("incrementStrawBingo", PlayerPrefs.GetInt("incrementStrawBingo") - 1);
            GameObject.Find("strawberryText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementStrawBingo").ToString();
        }
        else if (gameObject.name == "Grapes" && PlayerPrefs.GetInt("incrementGrapesBingo") > 0)
        {
            PlayerPrefs.SetInt("incrementGrapesBingo", PlayerPrefs.GetInt("incrementGrapesBingo") - 1);
            GameObject.Find("grapesText").GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("incrementGrapesBingo").ToString();
        }
    }
}
