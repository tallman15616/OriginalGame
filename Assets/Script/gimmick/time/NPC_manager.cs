using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_manager : MonoBehaviour
{
    private GameObject[] NPCBox;
    public List<GameObject> NPC_pornList;
    public GameObject player;

    void Update()
    {
        NPC_count();
    }

    //フィールド上のNPCの数をカウント
    void NPC_count()
    {
        //フィールド上のNPCをタグから数えて配列に入れる
        NPCBox = GameObject.FindGameObjectsWithTag("NPC");
        //Debug.Log("NPCの数：" + NPCBox.Length);


        if (player.activeSelf)
        {
            //プレイヤーのactiveセルフがオンの時
            if (NPCBox.Length > 40)
            {
                //NPCの数が40を超えるとき、NPCの生成を止める
                for (int i = 0; i < NPC_pornList.Count; i++)
                {
                    NPC_pornList[i].GetComponent<NPC_generation>().enabled = false;
                }
            }
            else if (NPCBox.Length <= 40)
            {
                //NPCの数が40以下の時生成を続ける
                for (int i = 0; i < NPC_pornList.Count; i++)
                {
                    NPC_pornList[i].GetComponent<NPC_generation>().enabled = true;
                }
            }
        }
        else
        {
            //プレイヤーのactiveセルフがオフの時
            //NPCの生成をオフにし、全てのNPCを削除

            for (int i = 0; i < NPC_pornList.Count; i++)
            {
                NPC_pornList[i].GetComponent<NPC_generation>().enabled = false;
            }

            foreach (GameObject allNPC in NPCBox)
            {
                Destroy(allNPC);
            }
        }
    }
}
