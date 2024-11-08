using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_reset : MonoBehaviour
{
    public GameObject player;
    public GameObject npc;
    private Vector3 npc_position;
    private Quaternion npc_rotation;
    private float npc_losttime;
    private void Start()
    {
        //NPCをリスポーンするスクリプト
        npc_position = npc.gameObject.transform.position;
        npc_rotation = npc.gameObject.transform.rotation;
    }
    private void Update()
    {
        Rispron();
    }
    void Rispron()
    {
        //playerがオフの時、NPCを初期位置に戻しオフにする
        if (player.activeSelf == false)
        {
            //npcを初期位置へ移動
            npc.gameObject.transform.position = npc_position;
            npc.gameObject.transform.rotation = npc_rotation;

            //NPCをオフに
            npc.SetActive(false);
        }
    }
}
