using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_res : MonoBehaviour
{
    //NPCをリスポーンさせるスクリプト
    public GameObject player;
    public GameObject npc;
    private Vector3 npc_position;
    private Quaternion npc_rotation;
    private void Start()
    {
        npc_position = npc.gameObject.transform.position;
        npc_rotation = npc.gameObject.transform.rotation;
    }
    private void Update()
    {
        Invoke("rispron", 0.2f);

    }
    void rispron()
    {
        //playerのactiveがオフの時、NPCを初期位置にしてactiveをオンに
        if (player.activeSelf == false)
        {
            npc.gameObject.transform.position = npc_position;
            npc.gameObject.transform.rotation = npc_rotation;
            npc.gameObject.SetActive(true);
        }
    }
}

