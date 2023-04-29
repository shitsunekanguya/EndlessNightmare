using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManage : MonoBehaviour
{
    public static int ending;
    public Unlock unlock;
    public GameObject U;
    public GameObject AV;
    public GameObject AAA;
    public GameObject AA;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject W;
    public GameObject F;
    public GameObject NEW;
    public static bool u = false;
    public static bool av = false;
    public static bool aaa = false;
    public static bool aa = false;
    public static bool a = false;
    public static bool b = false;
    public static bool c = false;
    public static bool d = false;
    public static bool w = false;
    public static bool f = false;

    public AudioSource Tada;
    // Start is called before the first frame update
    void Start()
    {
        U.SetActive(false);
        AV.SetActive(false);
        AAA.SetActive(false);
        AA.SetActive(false);
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        W.SetActive(false);
        F.SetActive(false);
        NEW.SetActive(false);
}

    // Update is called once per frame
    void Update()
    {
        if (ScoreStorage.Stored < 50)
        {
            F.SetActive(true);
            if (f == false)
            {
                f = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 50 && ScoreStorage.Stored < 70)
        {
            W.SetActive(true);
            if (w == false)
            {
                w = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 70 && ScoreStorage.Stored < 80)
        {
            D.SetActive(true);
            if (d == false)
            {
                d = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 80 && ScoreStorage.Stored < 90)
        {
            C.SetActive(true);
            if (c == false)
            {
                c = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 90 && ScoreStorage.Stored < 100)
        {
            B.SetActive(true);
            if (b == false)
            {
                b = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 100 && ScoreStorage.Stored < 130)
        {
            A.SetActive(true);
            if (a == false)
            {
                a = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 130 && ScoreStorage.Stored < 170)
        {
            AA.SetActive(true);
            if (aa == false)
            {
                aa = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 170 && ScoreStorage.Stored < 200)
        {
            AAA.SetActive(true);
            if (aaa == false)
            {
                aaa = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else if (ScoreStorage.Stored >= 200 && ScoreStorage.Stored < 300)
        {
            AV.SetActive(true);
            if (av == false)
            {
                av = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        else
        {
            U.SetActive(true);
            if (u == false)
            {
                u = true;
                ending += 1;
                Tada.Play();
                NEW.SetActive(true);
            }
        }
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
        }
    }
}
