using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror_tixt : MonoBehaviour
{
    //�I�u�W�F�N�g��I�������active���I�t�ɂ���X�N���v�g
    public GameObject Text_1;
    void Start()
    {
        Text_1.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text_1.SetActive(true);
        }
        else
        {
            Text_1.SetActive(false);
        }
            
        if (Input.GetKeyDown(KeyCode.E))
        {
            Text_1.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text_1.SetActive(false);
        }
    }
}
