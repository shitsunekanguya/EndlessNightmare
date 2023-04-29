using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image1 : MonoBehaviour
{
    Image m_Image;
    public Sprite aa;
    public Sprite bb;
    public Sprite cc;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
    }

    public void Au()
    {
        m_Image.sprite = aa;
    }
    public void Bu()
    {
        m_Image.sprite = bb;
    }
    public void Cu()
    {
        m_Image.sprite = cc;
    }
}
