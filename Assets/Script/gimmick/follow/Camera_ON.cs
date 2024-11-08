using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ON : MonoBehaviour
{
    //カメラをxとyは固定しz軸のみ動くようにする
    private GameObject player;   //プレイヤー情報格納用
    private Vector3 camera_p;      //相対距離取得用
    private Quaternion camera_r;   //subcamera角度固定用

    private GameObject mainCamara;
    private GameObject sub_Camera;

    void Start()
    {
        mainCamara = GameObject.Find("MainCamera");
        sub_Camera = GameObject.Find("Under_Camera");
        player = GameObject.Find("PlayerArmature");

        // MainCamera(自分自身)とplayerとの相対距離を求める
        camera_p = sub_Camera.transform.position - player.transform.position;
        //subcameraの初期角度取得
        camera_r = sub_Camera.transform.rotation;

        mainCamara.gameObject.SetActive(false);
        sub_Camera.gameObject.SetActive(true);
    }
    void Update()
    {
        Camera();
    }

    void Camera()
    {
        //カメラを常にplayerに向ける
        sub_Camera.transform.LookAt(player.transform);
        //カメラをプレイヤーとの距離分固定して追従
        sub_Camera.transform.position = player.transform.position + camera_p;
        //カメラ角度固定
        sub_Camera.transform.rotation = camera_r;

        //ｘとｙ軸を0ｆに固定。ｚ軸のみ動くように
        //sub_Camera.transform.position = new Vector3(camera_p.x , 0.0f, camera_p.z);
        //sub_Camera.transform.position += player.transform.position;
    }
}
