using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player_reset : MonoBehaviour
{
    //player�����X�|�[��������X�N���v�g
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
            //���ԉ��Z
            losttime += Time.deltaTime;

            //3���ȏ�̎�
            if (losttime >= 3f)
            {
                //player�������ʒu�ֈړ����N��
                player.gameObject.transform.position = initialPosition;
                player.gameObject.transform.rotation = initialRotation;
                player.gameObject.SetActive(true);
                losttime = 0;
            }
        }
    }
}

