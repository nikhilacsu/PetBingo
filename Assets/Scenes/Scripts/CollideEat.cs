using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class CollideEat : MonoBehaviour
{
    //This method is used to animate the fruit if it is near to the rabbit
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInChildren<Animator>().enabled = true;
        Destroy(gameObject, 1);     
    }
}
