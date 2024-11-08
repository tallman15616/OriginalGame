using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField]
    private Transform target;//�Ώ�(player)
    private float angle;//�p�x
    [SerializeField]
    private float rotateSpeed = 180f;//��]���x
    public Vector3 distanceFromTarget;//target����̋���
    [SerializeField] private Transform _self;//���g�̋���

    void Update()
    {
        this.transform.LookAt(target.transform);
        //�@���j�b�g�̈ʒu = �^�[�Q�b�g�̈ʒu �{ �^�[�Q�b�g���猩�����j�b�g�̊p�x �~�@�^�[�Q�b�g����̋���
        transform.position = target.position + Quaternion.Euler(0f, angle, 0f) * distanceFromTarget;
        //�@���j�b�g�̊p�x��ύX
        angle += rotateSpeed * Time.deltaTime;
        //�@�p�x��0�`360�x�̊ԂŌJ��Ԃ�
        angle = Mathf.Repeat(angle, 360f);
    }
}
