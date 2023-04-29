using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    public static bool DialogFile1;
    public static bool DialogFile2;
    public static bool DialogFile3;
    public Fadein black;
    public GameObject D1;
    public GameObject D2;
    public GameObject t;
    public GameObject p;
    public GameObject lv1;
    public GameObject lv2;
    public GameObject lv3;
    public GameObject W;
    public GameObject Set1;
    public GameObject Vs;
    public GameObject Next;
    public GameObject BG2;
    // Start is called before the first frame update
    void Start()
    {
        DialogFile1 = false;
        DialogFile2 = false;
        DialogFile3 = false;
        black.FadeIn();
        D1.SetActive(false);
        D2.SetActive(false);
        t.SetActive(false);
        p.SetActive(false);
        lv1.SetActive(false);
        lv2.SetActive(false);
        lv3.SetActive(false);
        W.SetActive(false);
        Vs.SetActive(false);
        Next.SetActive(false);
        BG2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Delete()
    {
        StartCoroutine(Shoo());
    }
    IEnumerator Shoo()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(D1);
        Destroy(Set1);
        BG2.SetActive(true);
        StartCoroutine(ToSleep());
    }
    IEnumerator ToSleep()
    {
        yield return new WaitForSeconds(1f);
        black.FadeOut();
        D2.SetActive(true);
    }
}
