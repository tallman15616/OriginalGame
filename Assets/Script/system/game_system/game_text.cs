using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_text : MonoBehaviour
{
    public GameObject dialogue;
    public Text Text;

    [SerializeField]
    string words = "ここにセリフ";

    //テキスト・json・Excelなどから参照する方法
    //外部から書き込み・読み込み

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text.text = words;
            dialogue.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogue.SetActive(false);
        }
    }
}
