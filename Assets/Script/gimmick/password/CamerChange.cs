using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class CamerChange : MonoBehaviour
{
    //�J������؂�ւ���X�N���v�g
    private GameObject mainCamara;
    private GameObject password_Camera;
    public GameObject player_controller;
    private GameObject player_mesh;
    private Renderer player_renderer;

    public bool cursor = false;

    void Start()
    {
        mainCamara = GameObject.Find("MainCamera");
        password_Camera = GameObject.Find("Password_Camera");
        player_mesh = GameObject.Find("Armature_Mesh");
        player_controller = GameObject.Find("PlayerArmature");

        player_renderer = player_mesh.GetComponent<Renderer>();

        password_Camera.SetActive(false);
        cursor = false;

        //�}�E�X�|�C���^�[�I�t
        Cursor.visible = false;
        //�|�C���^�[����ʒ����ɌŒ�
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerStay(Collider other)
    {
        //player���I�u�W�F�N�g�̋߂��ɂ���Ƃ�
        if (other.gameObject.CompareTag("Player"))
        {
            //E�L�[����͂����Ƃ�
             if (Input.GetKeyDown(KeyCode.E))
            {
                //���C���J������active�؂�ւ��@���@�p�X���[�h�J����active�؂�ւ�
                mainCamara.gameObject.SetActive(!mainCamara.gameObject.activeSelf);
                password_Camera.gameObject.SetActive(!password_Camera.gameObject.activeSelf);

                //Debug.Log("OPEN");
                if (cursor == false)
                {
                    cursor = true;

                    //player�R���g���[���[�I�t
                    player_controller.GetComponent<ThirdPersonController>().enabled = false;
                    //�}�E�X�|�C���^�[�I��
                    Cursor.visible = true;
                    //�|�C���^�[�����Œ����
                    Cursor.lockState = CursorLockMode.None;
                    //player��\����
                    player_renderer.enabled = false;
                }
                else
                {
                    cursor = false;
                    //player�R���g���[���[���I����
                    player_controller.GetComponent<ThirdPersonController>().enabled = true;
                    //�}�E�X�|�C���^�[�I�t
                    Cursor.visible = false;
                    //�|�C���^�[�����Œ�
                    Cursor.lockState = CursorLockMode.Locked;
                    //player�\��
                    player_renderer.enabled = true;
                }
            }
        }
    }
}
