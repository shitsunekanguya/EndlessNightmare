using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HscoreShow : MonoBehaviour
{
    public Text Hscore;
    int HShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HShow = ScoreStorage.HightScore;
        Hscore.text = HShow.ToString();
    }
}
