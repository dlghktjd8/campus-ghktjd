using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackSceneBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
