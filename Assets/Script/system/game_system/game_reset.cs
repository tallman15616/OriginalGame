using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_reset : MonoBehaviour
{
    public string scene_name;
    public GameObject reset;
    void Update()
    {
        if (reset.activeSelf)
        {
            SceneManager.LoadScene(scene_name);
        }
    }
}
