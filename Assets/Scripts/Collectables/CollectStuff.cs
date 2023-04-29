using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStuff : MonoBehaviour
{
    public AudioSource SmokeFX;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
    
        {
            SmokeFX.Play();
            //CollactableControl.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}
