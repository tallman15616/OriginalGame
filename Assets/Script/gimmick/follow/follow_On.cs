using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_On : MonoBehaviour
{
    //part���ݒ肳�ꂽ���𓥂ނ�follow���N��
    //player��active���I�t�ɂȂ����Ƃ��Afollow���I�t�ɂȂ�
    public GameObject follow;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("PlayerArmature");
        follow.SetActive(false);
    }

    private void Update()
    {
        Res();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            follow.SetActive(true);
        }
    }

    private void Res()
    {
        if (!player.activeSelf)
        {
            follow.SetActive(false);
        }
    }
}
