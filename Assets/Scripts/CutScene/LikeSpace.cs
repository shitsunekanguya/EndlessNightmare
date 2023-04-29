using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LikeSpace : MonoBehaviour
{
    // Start is called before the first frame update
    public void GO()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
