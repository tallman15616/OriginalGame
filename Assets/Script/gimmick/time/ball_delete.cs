using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_delete : MonoBehaviour
{
    public string Tag_name = "Ball";
    void OnTriggerEnter(Collider other)
    {
        //Ballのタグに接触したとき、ボールのオブジェクトを削除
        if(other.gameObject.tag == Tag_name)
        {
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Ballのタグに接触したとき、ボールのオブジェクトを削除
        if (collision.gameObject.tag == Tag_name)
        {
            Destroy(collision.gameObject);
        }
    }
}
