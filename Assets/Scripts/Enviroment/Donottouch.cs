using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donottouch : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wall")

        {
            Destroy(this.gameObject);
        }
    }
}
