using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_generate : MonoBehaviour
{
    //ボールを生成するスクリプト

    public GameObject Ball;
    //public int Ball_count = 0;
    private int time;

    void Update()
    {
        Debug.Log(time);
        Ball_generate();
        //非同期処理
        //pause中にbool判定で止める
        //特定の処理をすると全て停止する
    }

    void Ball_generate()
    {
        //　1加算
        time += 1;
        //120で割り切れるときボールを生成
        if (time % 120 == 0)
        {
            Instantiate(Ball, new Vector3( Random.Range
                                         (this.transform.position.x - 10, 
                                          this.transform.position.x + 10), 
                                          this.transform.position.y, 
                                          this.transform.position.z), 
                                          Quaternion.identity);
        }
    }
}
