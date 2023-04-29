using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasBG : MonoBehaviour
{
    Image m_Image;
    public Sprite N;
    public Sprite B;

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
        m_Image.sprite = N;
    }

    public void Blur()
    {
        m_Image.sprite = B;
    }

}
