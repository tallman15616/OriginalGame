using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class NPC_generation : MonoBehaviour
{
    //NPC�𐶐�����X�N���v�g

    public int npc_men = 10;
    public int count = 0;
    public GameObject NPC;
    public GameObject NPC_clone;
    public List<GameObject> NPCs;
    private int time;

    void Update()
    {
        Ball_generate();
        //Debug.Log(NPCs.Count);
    }

    void Ball_generate()
    {
        //time��10��菬�����Ƃ�NPC�𐶐�
        if (time < 10)
        {
            time += 1;
            
            if (time % 6 == 0 && NPCs.Count < npc_men)
            {
               
                Debug.Log("time = " + time);
                Debug.Log("NPCs = " + NPCs.Count);

                for (int i = 0; i < npc_men; i++)
                {
                    //time��120�Ŋ����Ƃ�NPC�𐶐����Atime��1���Z
                    NPC_clone = Instantiate(NPC, new Vector3(Random.Range
                                                 (this.transform.position.x - 3,
                                                  this.transform.position.x + 3),
                                                  this.transform.position.y,
                                                  this.transform.position.z),
                                                  Quaternion.identity);

                    NPCs.Add(NPC_clone);
                    //Debug.Log(NPCs.Count);
                }
            }
        }
        else if(time >= 10)
        {
            //time��10�ȏ�̎��Atime��������
            time = 0;
        }
    }
}
