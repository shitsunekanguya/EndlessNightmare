using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet2 : MonoBehaviour
{
    //public GameObject coinDetectorObj;

    void Start()
    {
        //coinDetectorObj = GameObject.FindGameObjectWithTag("Coin Detector");
        //coinDetectorObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //coinDetectorObj.SetActive(false);
            //StartCoroutine(ActivateCoin());
            Destroy(gameObject);
        }
    }

    /*IEnumerator ActivateCoin()
    {
        coinDetectorObj.SetActive(true);
        yield return new WaitForSeconds(10f);
        coinDetectorObj.SetActive(false);
    }*/

}
