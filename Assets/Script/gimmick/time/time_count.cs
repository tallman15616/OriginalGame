using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_count : MonoBehaviour
{
    //制限時間
    public float time = 30.0f;
    public float farst_time = 30.0f;
    //制限時間表示テキスト
    public Text timerText;
    //タイムアップテキスト
    public Text timeUpText;

    public GameObject player;

    void Update()
    {
        TimeCount();
        Count_Reset();
    }

    void TimeCount()
    {
        if (0 < time)
        {
            //時間経過をカウント
            time -= Time.deltaTime;
            timerText.text = time.ToString("F1");
        }
        else if (time <= 0)
        {
            //制限時間になったとき
            player.SetActive(false);
        }
    }

    void Count_Reset()
    {
        if (!player.activeSelf)
        {
            //プレイヤー非表示の時
            //タイム初期化・タイムアップテキスト表示
            time = farst_time;
            timerText.enabled = false;
            timeUpText.enabled = true;

            timeUpText.text = "TIME UP";
        }
        else
        {
            //プレイヤー表示の時
            //タイムカウント表示
            timerText.enabled = true;
            timeUpText.enabled = false;
        }
    }
}
