using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog2 : MonoBehaviour
{
    public AudioSource Bright;
    public AudioSource Scary;
    public AudioSource Night;
    public AudioSource Click;

    public Text dialog;
    public int line = 0;
    public float TimeToType = 3.0f;
    public bool endWord = false;
    public float textPercentage = 0f;
    public TextAsset textFile;
    public bool isNext = false;

    public Fadein fadein;
    public CutSceneManager CS;
    public CanvasBG BG;
    public CanvasPlayer Player;
    public CavvasTeach Teach;
    public GameObject bg;
    public GameObject player;
    public GameObject teacher;
    public GameObject D2;
    public GameObject lv1;
    public GameObject lv2;
    public GameObject lv3;
    public GameObject W;
    // Start is called before the first frame update

    void Start()
    {
        GetDialog(0);
        teacher.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        GetDialog(line);
        if (Input.GetMouseButtonDown(0))
        {
            Click.Play();
            line = line + 1;
            textPercentage = 0f;
            endWord = false;
        }
        if (line == 1)
        {
            teacher.SetActive(false);
            player.SetActive(true);
        }
        else if (line == 2)
        {
            teacher.SetActive(true);
            player.SetActive(false);
            lv1.SetActive(true);
        }
        else if (line == 3)
        {
            teacher.SetActive(false);
            player.SetActive(true);
            Player.WTF();
            Bright.Stop();
            Scary.Play();
        }
        else if (line == 4)
        {
            teacher.SetActive(true);
            player.SetActive(false);
            lv2.SetActive(true);

        }
        else if (line == 7)
        {
            teacher.SetActive(false);
            player.SetActive(true);
        }
        else if (line == 8)
        {
            teacher.SetActive(true);
            player.SetActive(false);
            lv3.SetActive(true);
        }
        else if (line == 9)
        {
            teacher.SetActive(false);
            player.SetActive(true);
        }
        else if (line == 10)
        {
            teacher.SetActive(true);
            player.SetActive(false);
        }
        else if (line == 11)
        {
            teacher.SetActive(false);
            player.SetActive(true);
        }
        else if (line == 12)
        {
            Scary.Stop();
            teacher.SetActive(true);
            player.SetActive(false);
        }
        else if (line == 13)
        {
            Bright.Play();
            teacher.SetActive(false);
            player.SetActive(false);
            W.SetActive(true);
            lv1.SetActive(false);
            lv2.SetActive(false);
            lv3.SetActive(false);

        }
        else if (line == 14)
        {
            teacher.SetActive(true);
            player.SetActive(false);
            W.SetActive(false);
            Teach.LOL();
        }
        else if (line == 15)
        {
            fadein.FadeIn();
            CS.Delete();
            Bright.Stop();
            Night.Play();
            Destroy(this.gameObject);
        }

    }


    void GetDialog(int line)
    {
        string[] linesInFile;
        linesInFile = textFile.text.Split('\n');
        if (line < linesInFile.Length)
        {
            callTyping(linesInFile[line]);
        }

    }

    void callTyping(string TextToType)
    {
        int numberOfLettersToShow = (int)(TextToType.Length * textPercentage);
        dialog.text = TextToType.Substring(0, numberOfLettersToShow);
        textPercentage += Time.deltaTime / TimeToType;
        textPercentage = Mathf.Min(1.0f, textPercentage);
        if (textPercentage == 1)
        {
            endWord = true;

        }
    }

}
