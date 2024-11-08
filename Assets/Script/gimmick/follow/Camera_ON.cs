using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ON : MonoBehaviour
{
    //�J������x��y�͌Œ肵z���̂ݓ����悤�ɂ���
    private GameObject player;   //�v���C���[���i�[�p
    private Vector3 camera_p;      //���΋����擾�p
    private Quaternion camera_r;   //subcamera�p�x�Œ�p

    private GameObject mainCamara;
    private GameObject sub_Camera;

    void Start()
    {
        mainCamara = GameObject.Find("MainCamera");
        sub_Camera = GameObject.Find("Under_Camera");
        player = GameObject.Find("PlayerArmature");

        // MainCamera(�������g)��player�Ƃ̑��΋��������߂�
        camera_p = sub_Camera.transform.position - player.transform.position;
        //subcamera�̏����p�x�擾
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
        //�J���������player�Ɍ�����
        sub_Camera.transform.LookAt(player.transform);
        //�J�������v���C���[�Ƃ̋������Œ肵�ĒǏ]
        sub_Camera.transform.position = player.transform.position + camera_p;
        //�J�����p�x�Œ�
        sub_Camera.transform.rotation = camera_r;

        //���Ƃ�����0���ɌŒ�B�����̂ݓ����悤��
        //sub_Camera.transform.position = new Vector3(camera_p.x , 0.0f, camera_p.z);
        //sub_Camera.transform.position += player.transform.position;
    }
}
