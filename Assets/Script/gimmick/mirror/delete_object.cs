using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_object : MonoBehaviour
{
    //�I�u�W�F�N�g��I�������active���I�t�ɂ���X�N���v�g
    public GameObject Text_1;
    //public GameObject player;
    private bool Ontext1;
    void Start()
    {
        Text_1.SetActive(false);
        //player = GameObject.Find("PlayerArmature");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //�I�u�W�F�N�g�ɋ߂Â��ƃe�L�X�g�\��
            Text_1.SetActive(true);
        }
        else
        {
            Text_1.SetActive(false);
        }
        
        //E�L�[����͂���Ƃ��̃I�u�W�F�N�g��active���I�t�ɂ���
        if (Input.GetKeyDown(KeyCode.E))
        {
            Text_1.SetActive(false);
            this.gameObject.SetActive(false);
            //player.SetActive(false);
        }
    }

    //�I�u�W�F�N�g���痣���ƃe�L�X�g�\���I�t
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text_1.SetActive(false);
        }
    }
}
