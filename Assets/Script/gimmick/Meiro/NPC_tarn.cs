using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_tarn : MonoBehaviour
{
    //NPC���o��������X�N���v�g
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
        //�ݒ肵���G���A����o�����ANPC���o��
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
