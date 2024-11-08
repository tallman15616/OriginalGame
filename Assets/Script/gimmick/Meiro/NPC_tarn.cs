using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_tarn : MonoBehaviour
{
    //NPCを出現させるスクリプト
    public List<GameObject> NPC_Runner;
    void Start()
    {
        for(int i = 0; i < NPC_Runner.Count; i++)
        {
            NPC_Runner[i].gameObject.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        //設定したエリアから出た時、NPCを出現
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < NPC_Runner.Count; i++)
            {
                NPC_Runner[i].gameObject.SetActive(true);
                //Debug.Log(i);
            }
        }
    }
}
