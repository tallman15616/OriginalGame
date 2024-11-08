using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_start : MonoBehaviour
{
    public Text text ;

    public void SwitchScene()
    {
        text.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        SceneManager.LoadScene("unknown", LoadSceneMode.Single);
    }
}
