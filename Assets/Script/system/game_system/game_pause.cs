using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_pause : MonoBehaviour
{
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    void Pause()
    {
        //qを押したとき
        if (Input.GetKeyDown("q"))
        {
            //pauseUIInstanceにobjectが割り当てられてないとき
            if (pauseUIInstance == null)
            {
                //pauseUIInstanceにpauseUIPrefabを生成し、割り当てる
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                //ゲーム内の時間を停止
                Time.timeScale = 0f;
            }
            else
            {
                //生成したpause画面を停止
                Destroy(pauseUIInstance);
                //時間を動かす
                Time.timeScale = 1f;
            }
        }
    }
}
