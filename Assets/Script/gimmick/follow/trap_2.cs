using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_2 : MonoBehaviour
{
    //part��face�̋N���X�N���v�g
    //�ݒ肵�����𓥂ނ�2�����face���o��
    //�������2�����face���o���A���X�ɑO�ɐi��ł���
    //player��active���I�t�A���͕ǂɓ�����ƃ��Z�b�g
    public GameObject other;
    public GameObject player;
    private GameObject wall;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private float time = 0f;

    void Start()
    {
        wall = GameObject.Find("Box_100x100x100_Prefab (21)");
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
        Player();

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
        //face�̈ʒu�Ɂ@�O�����@*�@8�@*�@�Q�[�������ԁ@�����Z
        other.transform.position += Vector3.forward * 8 * Time.deltaTime;
        time += Time.deltaTime;
    }
    private void Player()
    {
        if(player.activeSelf == false || 
            other.gameObject.transform.position == wall.gameObject.transform.position)
        {
            other.gameObject.transform.position = initialPosition;
            other.gameObject.transform.rotation = initialRotation;
            other.gameObject.SetActive(false);
        }
    }
}
