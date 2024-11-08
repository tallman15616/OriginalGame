using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_object : MonoBehaviour
{
    //オブジェクトを選択するとactiveをオフにするスクリプト
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
            //オブジェクトに近づくとテキスト表示
            Text_1.SetActive(true);
        }
        else
        {
            Text_1.SetActive(false);
        }
        
        //Eキーを入力するとこのオブジェクトのactiveをオフにする
        if (Input.GetKeyDown(KeyCode.E))
        {
            Text_1.SetActive(false);
            this.gameObject.SetActive(false);
            //player.SetActive(false);
        }
    }

    //オブジェクトから離れるとテキスト表示オフ
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text_1.SetActive(false);
        }
    }
}
