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

    //�t�B�[���h���NPC�̐����J�E���g
    void NPC_count()
    {
        //�t�B�[���h���NPC���^�O���琔���Ĕz��ɓ����
        NPCBox = GameObject.FindGameObjectsWithTag("NPC");
        //Debug.Log("NPC�̐��F" + NPCBox.Length);


        if (player.activeSelf)
        {
            //�v���C���[��active�Z���t���I���̎�
            if (NPCBox.Length > 40)
            {
                //NPC�̐���40�𒴂���Ƃ��ANPC�̐������~�߂�
                for (int i = 0; i < NPC_pornList.Count; i++)
                {
                    NPC_pornList[i].GetComponent<NPC_generation>().enabled = false;
                }
            }
            else if (NPCBox.Length <= 40)
            {
                //NPC�̐���40�ȉ��̎������𑱂���
                for (int i = 0; i < NPC_pornList.Count; i++)
                {
                    NPC_pornList[i].GetComponent<NPC_generation>().enabled = true;
                }
            }
        }
        else
        {
            //�v���C���[��active�Z���t���I�t�̎�
            //NPC�̐������I�t�ɂ��A�S�Ă�NPC���폜

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
