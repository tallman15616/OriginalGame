using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror_count : MonoBehaviour
{
    public List<GameObject> true_Object;
    public List<GameObject> false_Object;
    public List<GameObject> left_Objects;

    public GameObject player;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    public GameObject door;

    void Start()
    {
        door.gameObject.SetActive(false);
        initialPosition = player.gameObject.transform.position;
        initialRotation = player.gameObject.transform.rotation;
    }

    void Update()
    {
        Objecut_count();
    }

    void Objecut_count()
    {
            //true_Object���S�ď������
            if(true_Object[0].activeSelf == false &&
               true_Object[1].activeSelf == false &&
               true_Object[2].activeSelf == false &&
               true_Object[3].activeSelf == false &&
               true_Object[4].activeSelf == false)
            {
                door.gameObject.SetActive (true);
            }

        for(int i = 0; i < false_Object.Count; i++)
        {
            //�Ԉ�����I�u�W�F�N�g��G�����Ƃ�
            if(!false_Object[i].activeSelf)
            {
                //�v���C���[���I�t��
                //�h�A���I�t��
                player.gameObject.SetActive(false);
                door.gameObject.SetActive(false);

                //�S�Ă̍��E�̕����̃I�u�W�F�N�g��������
                false_Object[i].gameObject.SetActive(true);

                for (int j = 0; j < true_Object.Count; j++)
                {
                    true_Object[j].gameObject.SetActive(true);
                }

                for (int k = 0; k < left_Objects.Count; k++)
                {
                    left_Objects[k].gameObject.SetActive(true);
                }
            }
        }
    }
}
