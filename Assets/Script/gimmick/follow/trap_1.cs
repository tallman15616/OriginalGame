using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_1 : MonoBehaviour
{
    //part��hand�̋N���X�N���v�g
    //�ݒ肵�����𓥂ނ�2�����hand���o��
    //�������2�����hand���o���A���X�ɑO�ɐi��ł���
    //player��active���I�t�A����3f��Ƀ��Z�b�g
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
        //Debug.Log("(x, y, z) = " + other.transform.position);
        //Debug.Log(time);

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
        //hand�̈ʒu�Ɂ@�O�����@*�@7�@*�@�Q�[�������ԁ@�����Z
        other.transform.position += Vector3.forward * 7 * Time.deltaTime;
        time += Time.deltaTime;
    }
    private void Res()
    {
        //3���𒴂������A����player��active���I�t�̂Ƃ�hand��������
        if (time >= 3f || player.activeSelf == false)
        {
            time = 0f;
            other.gameObject.transform.position = initialPosition;
            other.gameObject.transform.rotation = initialRotation;
            other.gameObject.SetActive (false);
        }
    }
}
