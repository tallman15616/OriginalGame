using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_generate : MonoBehaviour
{
    //�{�[���𐶐�����X�N���v�g

    public GameObject Ball;
    //public int Ball_count = 0;
    private int time;

    void Update()
    {
        Debug.Log(time);
        Ball_generate();
        //�񓯊�����
        //pause����bool����Ŏ~�߂�
        //����̏���������ƑS�Ē�~����
    }

    void Ball_generate()
    {
        //�@1���Z
        time += 1;
        //120�Ŋ���؂��Ƃ��{�[���𐶐�
        if (time % 120 == 0)
        {
            Instantiate(Ball, new Vector3( Random.Range
                                         (this.transform.position.x - 10, 
                                          this.transform.position.x + 10), 
                                          this.transform.position.y, 
                                          this.transform.position.z), 
                                          Quaternion.identity);
        }
    }
}
