using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_3 : MonoBehaviour
{
    //part��leg�̋N���X�N���v�g
    //�ݒ肵�����𓥂ނ�2�����leg���o��
    //��ɏo������leg�����X�ɉ��ɗ����Ă���
    //5���𒴂���A����player��active���I�t�ɂȂ�ƁAactive���I�t�ɂ��ď����ʒu��
    public GameObject other;
    public GameObject player;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private float time = 0f;

    void Start()
    {
        other.gameObject.SetActive(false);
        initialPosition = other.gameObject.transform.position;
        initialRotation = other.gameObject.transform.rotation;
    }
    void Update()
    {
        if (other.activeSelf)
        {
            Trap();
        }
        Res();
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("Porn", 2f);
        }
    }
    private void Porn()
    {
        other.gameObject.SetActive(true);
    }
    private void Trap()
    {
        //leg�̈ʒu�Ɂ@�������@*�@3�@*�@�Q�[�������ԁ@�����Z
        other.transform.position += Vector3.down * 3 * Time.deltaTime;
        time += Time.deltaTime;
    }
    private void Res()
    {
        //5���𒴂������A����player��active���I�t�̂Ƃ�leg��������
        if (time >= 5f || player.activeSelf == false)
        {
            time = 0f;
            other.gameObject.transform.position = initialPosition;
            other.gameObject.transform.rotation = initialRotation;
            other.gameObject.SetActive(false);
        }
    }

}
