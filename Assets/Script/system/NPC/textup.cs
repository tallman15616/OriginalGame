using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textup : MonoBehaviour
{
    //�߂Â�����e�L�X�g��\��
    private MeshRenderer textMesh;
void Start ()
{
    textMesh = GetComponent<MeshRenderer>();
    textMesh.enabled = false;
}
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            textMesh.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            textMesh.enabled = false;
        }
    }
}
