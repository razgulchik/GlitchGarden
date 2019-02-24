using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basezone : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LivesDisplay>().ReduceLive();
        //collision.gameObject.Destroy();
    }
}
