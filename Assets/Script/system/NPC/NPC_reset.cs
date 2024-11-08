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
        //NPC�����X�|�[������X�N���v�g
        npc_position = npc.gameObject.transform.position;
        npc_rotation = npc.gameObject.transform.rotation;
    }
    private void Update()
    {
        Rispron();
    }
    void Rispron()
    {
        //player���I�t�̎��ANPC�������ʒu�ɖ߂��I�t�ɂ���
        if (player.activeSelf == false)
        {
            //npc�������ʒu�ֈړ�
            npc.gameObject.transform.position = npc_position;
            npc.gameObject.transform.rotation = npc_rotation;

            //NPC���I�t��
            npc.SetActive(false);
        }
    }
}
