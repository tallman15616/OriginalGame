using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_delete2 : MonoBehaviour
{
    //�{�[���ɐڐG�����Ƃ��ANPC���폜
    public string Tag_name = "Ball";

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == Tag_name)
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
