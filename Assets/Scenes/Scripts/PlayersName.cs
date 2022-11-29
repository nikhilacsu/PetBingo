using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayersName : MonoBehaviour
{
    public string userNames;
    // Start is called before the first frame update
    void Start()
    {
        userNames = buttoncontrol.userName.ToString() + "'s";
        GetComponent<TMP_Text>().text = userNames;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
