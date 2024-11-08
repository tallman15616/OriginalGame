using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_pause : MonoBehaviour
{
    [SerializeField]
    //�@�|�[�Y�������ɕ\������UI�̃v���n�u
    private GameObject pauseUIPrefab;
    //�@�|�[�YUI�̃C���X�^���X
    private GameObject pauseUIInstance;

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    void Pause()
    {
        //q���������Ƃ�
        if (Input.GetKeyDown("q"))
        {
            //pauseUIInstance��object�����蓖�Ă��ĂȂ��Ƃ�
            if (pauseUIInstance == null)
            {
                //pauseUIInstance��pauseUIPrefab�𐶐����A���蓖�Ă�
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                //�Q�[�����̎��Ԃ��~
                Time.timeScale = 0f;
            }
            else
            {
                //��������pause��ʂ��~
                Destroy(pauseUIInstance);
                //���Ԃ𓮂���
                Time.timeScale = 1f;
            }
        }
    }
}
