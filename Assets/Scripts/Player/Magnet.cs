using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public static bool MagnetActive;
    public GameObject coinDetectorObj;
    //public int next = 100;

    void Start()
    {
        MagnetActive = false;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MagnetActive = true;
            StartCoroutine(StopMagnet());
        }
    }

    IEnumerator StopMagnet()
    {
        yield return new WaitForSeconds(0.1f);
        MagnetActive = false;
    }

}
