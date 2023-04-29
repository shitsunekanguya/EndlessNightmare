using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock : MonoBehaviour
{
    public GameObject black;
    // Start is called before the first frame update
    void Start()
    {
        black.SetActive(false);
        StartCoroutine(Fade(true));
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            FadeOut();
        }
    }
    // Update is called once per frame
    public void FadeIn()
    {
        black.SetActive(true);
        StartCoroutine(Fade());
    }
    public void FadeOut()
    {
        black.SetActive(true);
        StartCoroutine(Fade(false));
    }

    public IEnumerator Fade(bool fade = true, int speed = 3)
    {
        Color objectColor = black.GetComponent<Image>().color;
        float fadeAmount;

        if (fade)
        {
            while (black.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (speed * Time.deltaTime);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                black.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
        else
        {
            while (black.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (speed * Time.deltaTime);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                black.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
}
