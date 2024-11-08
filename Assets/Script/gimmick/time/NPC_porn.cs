using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPC_porn : MonoBehaviour
{
    //NPC�����X�|�[��������X�N���v�g
    public GameObject player;
    public List<GameObject> npc;
    private List<Vector3>  npc_position;
    private List<Quaternion>  npc_rotation;
    private void Start()
    {
        for (int i = 0; i < npc.Count; i++)
        {
            npc_position.Add(npc[i].gameObject.transform.position);
            npc_rotation.Add(npc[i].gameObject.transform.rotation);
        }
    }
    private void Update()
    {
        Rispron();
    }

    void Rispron()
    {
        //for (int i = 0; i < npc.Count; i++)
        //{
            //if (npc[i].activeSelf)
            //{
                //npc[i].gameObject.transform.position = npc_position[i];
                //npc[i].gameObject.transform.rotation = npc_rotation[i];
            //}
        //}

        //player��active���I�t�̎��ANPC�������ʒu�ɂ���active���I����
        if (player.activeSelf == false)
        {
            if (player.activeSelf)
            {
                Invoke("Palyer_deth", 0.3f);
            }
        }

        //npc���X�g�̓�active���I�t�̎��A�N��
        for (int i = 0; i < npc.Count; i++)
        {
            if (npc[i].activeSelf == false)
            {
                Invoke("Npc_deth",10f);
            }
        }
    }

    void Player_deth()
    {
        for (int i = 0; i < npc.Count; i++)
        {
            npc[i].gameObject.SetActive(true);
        }
    }

    void Npc_deth()
    {
        for (int i = 0; i < npc.Count; i++)
        {
            if (!npc[i].activeSelf)
            {
                //�������I�u�W�F�N�g�̃��X�g���̈ʒu���擾
                int npc_namber = npc.IndexOf(npc[i]);
                Debug.Log(npc_namber);

                //�������I�u�W�F�N�g��\��
                npc[npc_namber].SetActive(true);
                npc[npc_namber].gameObject.transform.position = npc_position[npc_namber];
                npc[npc_namber].gameObject.transform.rotation = npc_rotation[npc_namber];
            }
        }
    }
}
