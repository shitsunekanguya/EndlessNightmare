using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog3 : MonoBehaviour
{
    public AudioSource Bright;
    public AudioSource Scary;
    public AudioSource Night;
    public AudioSource Click;
    public AudioSource effect;

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
    public CanvasHouse house;
    public CanvasPlayer Player;
    public GameObject bg;
    public GameObject player;
    public GameObject teacher;
    public GameObject Next;
    public GameObject Vs;
    bool cango;
    // Start is called before the first frame update

    void Start()
    {
        GetDialog(0);
        cango = false;
        effect.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        GetDialog(line);
        if (Input.GetMouseButtonDown(0))
        {
            line = line + 1;
            textPercentage = 0f;
            endWord = false;
            if (line != 6)
            { Click.Play(); }
        
        }
        if (line == 1)
        {

            Bright.Stop();
            Vs.SetActive(true);
        }
        if (line == 2)
        {
            house.B();
        }
        else if (line == 3)
        {
            house.C();
        }
        else if (line == 5)
        {

            effect.Play();
            house.D();
        }
        else if (line == 6)
        {
            Vs.SetActive(false);
            house.E();
            StartCoroutine(Nextt());
        }
        if (cango == true)
        {
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
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
    IEnumerator Nextt()
    {
        yield return new WaitForSeconds(4f);
        Next.SetActive(true);
        cango = true;
    }

}
