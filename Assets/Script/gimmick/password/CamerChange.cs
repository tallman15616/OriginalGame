using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class CamerChange : MonoBehaviour
{
    //カメラを切り替えるスクリプト
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

        //マウスポインターオフ
        Cursor.visible = false;
        //ポインターを画面中央に固定
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerStay(Collider other)
    {
        //playerがオブジェクトの近くにいるとき
        if (other.gameObject.CompareTag("Player"))
        {
            //Eキーを入力したとき
             if (Input.GetKeyDown(KeyCode.E))
            {
                //メインカメラのactive切り替え　＆　パスワードカメラactive切り替え
                mainCamara.gameObject.SetActive(!mainCamara.gameObject.activeSelf);
                password_Camera.gameObject.SetActive(!password_Camera.gameObject.activeSelf);

                //Debug.Log("OPEN");
                if (cursor == false)
                {
                    cursor = true;

                    //playerコントローラーオフ
                    player_controller.GetComponent<ThirdPersonController>().enabled = false;
                    //マウスポインターオン
                    Cursor.visible = true;
                    //ポインター中央固定解除
                    Cursor.lockState = CursorLockMode.None;
                    //player非表示に
                    player_renderer.enabled = false;
                }
                else
                {
                    cursor = false;
                    //playerコントローラーをオンに
                    player_controller.GetComponent<ThirdPersonController>().enabled = true;
                    //マウスポインターオフ
                    Cursor.visible = false;
                    //ポインター中央固定
                    Cursor.lockState = CursorLockMode.Locked;
                    //player表示
                    player_renderer.enabled = true;
                }
            }
        }
    }
}
