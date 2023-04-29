using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasHouse : MonoBehaviour
{
    Image m_Image;
    public Sprite a;
    public Sprite b;
    public Sprite c;
    public Sprite d;
    public Sprite e;

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
        m_Image.sprite = a;
    }

    public void B()
    {
        m_Image.sprite = b;
    }
    public void C()
    {
        m_Image.sprite = c;
    }
    public void D()
    {
        m_Image.sprite = d;
    }
    public void E()
    {
        m_Image.sprite = e;
    }


}
