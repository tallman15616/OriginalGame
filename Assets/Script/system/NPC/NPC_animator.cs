using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_animator : MonoBehaviour
{
    //NPC�̃A�j���[�V�������N��
    private Animator animator;  // �A�j���[�^�[�R���|�[�l���g�擾�p
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
