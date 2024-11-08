using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    //�����鏰�̃X�N���v�g
    Rigidbody rb;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;//�����Ȃ��悤�ɂ������
        initialPosition = this.gameObject.transform.position;
        initialRotation = this.gameObject.transform.rotation;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("Fall", 3f);
        }
    }

    private void Fall()
    {
        //iskinematic���I�t�ɂ��ė����B5�����Resporn���N��
        rb.isKinematic = false;
        Invoke("Resporn", 5f);
    }

    private void Resporn()
    {
        //isKinematic���N���B���̏��������ʒu�ɖ߂�
        rb.isKinematic = true;
        this.gameObject.transform.position = initialPosition;
        this.gameObject.transform.rotation = initialRotation;
    }
}
