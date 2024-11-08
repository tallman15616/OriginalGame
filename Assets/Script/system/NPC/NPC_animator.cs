using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_animator : MonoBehaviour
{
    //NPCのアニメーションを起動
    private Animator animator;  // アニメーターコンポーネント取得用
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //float inputX = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        //float inputZ = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        if (GetComponent<Rigidbody>().IsSleeping())
        {
            animator.SetBool("stop", true);
        }
        else
        {
            animator.SetBool("stop", false);
        }
    }
}
