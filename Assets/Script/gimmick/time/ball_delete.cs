using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_delete : MonoBehaviour
{
    public string Tag_name = "Ball";
    void OnTriggerEnter(Collider other)
    {
        //Ball�̃^�O�ɐڐG�����Ƃ��A�{�[���̃I�u�W�F�N�g���폜
        if(other.gameObject.tag == Tag_name)
        {
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Ball�̃^�O�ɐڐG�����Ƃ��A�{�[���̃I�u�W�F�N�g���폜
        if (collision.gameObject.tag == Tag_name)
        {
            Destroy(collision.gameObject);
        }
    }
}
