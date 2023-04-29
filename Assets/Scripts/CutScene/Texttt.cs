using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texttt : MonoBehaviour
{
    public Text score;
    public Text Hscore;
    public Text Ending;
    int p;
    int Hp;
    int E;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        p = ScoreStorage.Stored;
        Hp = ScoreStorage.HightScore;
        E = EndSceneManage.ending;
        score.text = p.ToString();
        Hscore.text = Hp.ToString();
        Ending.text = E.ToString() +" / 10";
    }
}
