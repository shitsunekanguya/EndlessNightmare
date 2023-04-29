using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartIt : MonoBehaviour
{
    public Fadein f;
    void Start()
    {
        f.FadeOut();
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            f.FadeIn();
            StartCoroutine(Shoo());
        }
    }
    IEnumerator Shoo()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}
