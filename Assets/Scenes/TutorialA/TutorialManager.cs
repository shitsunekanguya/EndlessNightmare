using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public AudioSource Click;
    public GameObject Button;
    public GameObject Image1;
    public GameObject Image2;

    public Text dialog;
    public int line = 0;
    public float TimeToType = 3.0f;
    public bool endWord = false;
    public float textPercentage = 0f;
    public TextAsset textFile;
    public bool isNext = false;

    public Image1 im1;

    // Start is called before the first frame update

    void Start()
    {
        GetDialog(0);
        Button.SetActive(false);
        Image1.SetActive(true);
        Image2.SetActive(false);

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
            Click.Play();
        }
        if (line == 1)
        {
            im1.Au();
        }
        else if (line == 2)
        {
            Image1.SetActive(true);
            Image2.SetActive(false);
            im1.Bu();
        }
        else if (line == 3)
        {

            Image1.SetActive(false);
            Image2.SetActive(true);
        }
        else if (line == 4)
        {
            Image1.SetActive(true);
            Image2.SetActive(false);
            im1.Cu();
        }
        else if (line == 5)
        {
            Button.SetActive(true);
            Image2.SetActive(false);
        }

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
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
