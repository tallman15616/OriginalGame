using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_text : MonoBehaviour
{
    //�v���C���[���߂Â����Ƃ��e�L�X�g��\��
    private GameObject player;
    public GameObject Text_1;
    void Start()
    {
        player = GameObject.Find("PlayerArmature");
        Text_1.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                Text_1.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text_1.SetActive(false);
        }
    }

    //�v���C���[���I�t�ɂȂ����Ƃ��A�e�L�X�g��\��
    void textoff()
    {
        if(player.activeSelf == false)
        {
            Text_1.SetActive(false);
        }
    }
    private void Update()
    {
        textoff();
    }
}
