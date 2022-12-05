using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //This method is used to change scene on clicking the button.
    public void btn_change_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
