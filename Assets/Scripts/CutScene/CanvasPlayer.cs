using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasPlayer : MonoBehaviour
{
    Image m_Image;
    public Sprite smile;
    public Sprite wow;
    public Sprite wtf;

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
    }

    public void Smile()
    {
        m_Image.sprite = smile;
    }
    public void Wow()
    {
        m_Image.sprite = wow;
    }
    public void WTF()
    {
        m_Image.sprite = wtf;
    }
}
