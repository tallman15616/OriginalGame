using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player_reset : MonoBehaviour
{
    //playerをリスポーンさせるスクリプト
    public GameObject player;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private float losttime;
    void Start()
    {
        player.gameObject.SetActive(true);
        initialPosition = player.gameObject.transform.position;
        initialRotation = player.gameObject.transform.rotation;
    }
    private void Update()
    {
        Resporn();
    }

    private void Resporn()
    {
        if (player.activeSelf == false)
        {
            //時間加算
            losttime += Time.deltaTime;

            //3ｆ以上の時
            if (losttime >= 3f)
            {
                //playerを初期位置へ移動し起動
                player.gameObject.transform.position = initialPosition;
                player.gameObject.transform.rotation = initialRotation;
                player.gameObject.SetActive(true);
                losttime = 0;
            }
        }
    }
}

