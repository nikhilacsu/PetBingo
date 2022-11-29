using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class CollideEat : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInChildren<Animator>().enabled = true;
        UnityEngine.Debug.Log("Trigger Detected");
        Destroy(gameObject, 1);
        //StartCoroutine(SceneLoader());
        
    }
    /*IEnumerator SceneLoader()
    {
        UnityEngine.Debug.Log("Sceneloader");
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
        //yield return new WaitForSeconds(0.2f);
        GetComponentInChildren<Animator>().enabled = false;
        UnityEngine.Debug.Log("Set True");
        gameObject.SetActive(true);
    }*/
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
