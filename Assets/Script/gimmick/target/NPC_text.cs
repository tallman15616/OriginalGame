using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_text : MonoBehaviour
{
    //プレイヤーが近づいたときテキストを表示
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

    //プレイヤーがオフになったとき、テキスト非表示
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
