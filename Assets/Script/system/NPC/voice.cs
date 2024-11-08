using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
    public GameObject Text_1;
    public GameObject Text_2;
    private bool Ontext1;
    void Start()
    {
        Text_1.SetActive(false);
        Text_2.SetActive(false);
        Ontext1 = false;
    }
    void OnTriggerStay(Collider other)
    {
        //テキスト表示及び選択したとき別テキスト切り替え
        if(other.gameObject.CompareTag("Player"))
        {
            if (Ontext1 == false)
            {
                Text_1.SetActive(true);
            }
            else
            {
                Text_1.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Ontext1 == false)
                {
                    Text_1.gameObject.SetActive(false);
                    Ontext1 = true;
                }
                else if(Ontext1 == true)
                {
                    Text_1.gameObject.SetActive(true);
                    Ontext1 = false;
                }
                Text_2.gameObject.SetActive(!Text_2.gameObject.activeSelf);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        //離れた時全てのテキスト非表示
        if(other.gameObject.CompareTag("Player"))
        {
        Text_1.SetActive(false);
        Text_2.SetActive(false);
        Ontext1 = false;
        }
    }
}
