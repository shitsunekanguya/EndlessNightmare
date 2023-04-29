using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Totu : MonoBehaviour
{
    public void GO()
    {
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }
}
