using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialNumber : MonoBehaviour
{
    //ダイヤルをクリックされると数字を増やす
    [SerializeField] TMP_Text numberText = default;//表示する
    public int number = 0;//数字
    public void Onclick()
    {
        //クリックされるたび加算
        number++;

        //numberが9より大きくなる時、0へ
        if(number > 9)
        {
            number = 0;
        }

        //numberのテキストをstring型へ変換
        numberText.text = number.ToString();
        //Debug.Log(number);
    }
}