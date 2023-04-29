using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{

    public int X = 0;
    public int Y = 90;
    public int Z = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(X, Y, Z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
