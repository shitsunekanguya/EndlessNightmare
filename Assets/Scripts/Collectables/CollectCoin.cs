using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{


    public int cointCoint = 0;
    public AudioSource coinFX;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            coinFX.Play();
            CollactableControl.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}
