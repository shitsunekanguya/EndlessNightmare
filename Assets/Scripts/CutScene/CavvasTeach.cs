using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CavvasTeach : MonoBehaviour
{
    Image m_Image;
    public Sprite N;
    public Sprite S;

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
        m_Image.sprite = N;
    }

    public void LOL()
    {
        m_Image.sprite = S;
    }

}
