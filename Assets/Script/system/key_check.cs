using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����L�[�������ꂽ�ꍇ
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            { // ����
                if (Input.GetKeyDown(code))
                { // ���͂��ꂽ�L�[�̖��O�ƈ�v�����ꍇ
                    Debug.Log(code.ToString() + " �̃{�^���������ꂽ��I�I"); // �R���\�[���ɕ\��
                }
            }
        }
    }
}
