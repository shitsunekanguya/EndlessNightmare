using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreStorage : MonoBehaviour
{
    public static int Stored;
    public static int HightScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Stored = CollactableControl.coinCount;
        if (HightScore < Stored)
        {
            HightScore = Stored;
        }
        DontDestroyOnLoad(this);
    }
}
