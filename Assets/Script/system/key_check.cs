using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 何かキーが押された場合
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            { // 検索
                if (Input.GetKeyDown(code))
                { // 入力されたキーの名前と一致した場合
                    Debug.Log(code.ToString() + " のボタンが押されたよ！！"); // コンソールに表示
                }
            }
        }
    }
}
