using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoScreenMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer = 5f;
    private float timeElapsed;
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed>timer) {
            //Scene2 will be loaded after timer ends
            SceneManager.LoadScene("scene2");
        }       
    }
}
