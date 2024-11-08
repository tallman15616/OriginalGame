using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_count : MonoBehaviour
{
    //��������
    public float time = 30.0f;
    public float farst_time = 30.0f;
    //�������ԕ\���e�L�X�g
    public Text timerText;
    //�^�C���A�b�v�e�L�X�g
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
            //���Ԍo�߂��J�E���g
            time -= Time.deltaTime;
            timerText.text = time.ToString("F1");
        }
        else if (time <= 0)
        {
            //�������ԂɂȂ����Ƃ�
            player.SetActive(false);
        }
    }

    void Count_Reset()
    {
        if (!player.activeSelf)
        {
            //�v���C���[��\���̎�
            //�^�C���������E�^�C���A�b�v�e�L�X�g�\��
            time = farst_time;
            timerText.enabled = false;
            timeUpText.enabled = true;

            timeUpText.text = "TIME UP";
        }
        else
        {
            //�v���C���[�\���̎�
            //�^�C���J�E���g�\��
            timerText.enabled = true;
            timeUpText.enabled = false;
        }
    }
}
