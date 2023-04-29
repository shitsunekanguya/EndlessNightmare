using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToCutScene : MonoBehaviour
{
    public void GOTOCS()
    {
        SceneManager.LoadScene("CutScene", LoadSceneMode.Single);
    }
}
