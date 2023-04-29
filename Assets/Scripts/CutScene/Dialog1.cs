using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog1 : MonoBehaviour
{
    public AudioSource Bright;
    public AudioSource Scary;
    public AudioSource Night;
    public AudioSource Click;
    AudioSource Effect;
    public AudioClip Voice;

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
    public GameObject bg;
    public GameObject player;
    public GameObject teacher;
    public GameObject D1;
    // Start is called before the first frame update

    void Start()
    {
         GetDialog(0);
         Scary.Stop();
         Night.Stop();
         Bright.Play();
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
            if (line == 1)
            {
                player.SetActive(true);
                BG.Blur();
            }
            else if (line == 2)
            {
                Player.Wow();
            }
            else if (line == 3)
            {
                player.SetActive(false);
                D1.SetActive(true);
                Destroy(this.gameObject);
            }
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
