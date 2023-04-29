using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCollide : MonoBehaviour
{
    public bool Nocollide;
    // Start is called before the first frame update
    public void NoCollide()
    {
        GetComponent<Collider>().enabled = false;
    }
    public void Collide()
    {
        GetComponent<Collider>().enabled = true;
    }
    void Update()
    {
        Nocollide = PlayerMove.Collid;
        if (Nocollide == false)
        {
            GetComponent<Collider>().enabled = true;
        }
        else
        {
            GetComponent<Collider>().enabled = false;
        }
    }
}
