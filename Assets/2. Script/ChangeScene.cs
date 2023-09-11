using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "StartBtn":
                SceneManager.LoadScene("Start");
                break;
            case "OptionsBtn":
                SceneManager.LoadScene("Options");
                break;
            case "SttOptionsBtn":
                SceneManager.LoadScene("SttOptions");
                break;
            case "BackGameBtn":
                SceneManager.LoadScene("Start");
                break;
        }
    }
}
